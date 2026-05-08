using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TaskManager.Algorithms;
using TaskManager.Models;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridViewTasks.Columns.Clear();
            dataGridViewTasks.Columns.Add("Id", "ID");
            dataGridViewTasks.Columns.Add("Title", "Название");
            dataGridViewTasks.Columns.Add("Priority", "Приоритет");
            dataGridViewTasks.Columns.Add("Minutes", "Время (мин)");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название задачи!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = new TaskItem
            {
                Id = _nextId++,
                Title = txtTitle.Text,
                Priority = (Priority)Enum.Parse(typeof(Priority), cmbPriority.Text),
                EstimatedMinutes = (int)nudMinutes.Value
            };

            _tasks.Add(task);
            dataGridViewTasks.Rows.Add(task.Id, task.Title, task.Priority, task.EstimatedMinutes);

            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (_tasks.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну задачу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxSchedule.Items.Clear();
            var scheduler = new TaskManager.Algorithms.TaskScheduler();
            var schedule = scheduler.ScheduleTasks(_tasks);

            int position = 1;
            foreach (var scheduledTask in schedule)
            {
                string item = $"{position++}. [{scheduledTask.Task.Priority}] {scheduledTask.Task.Title} | " +
                             $"Старт: {scheduledTask.StartMinute} мин, " +
                             $"Финиш: {scheduledTask.EndMinute} мин | " +
                             $"Длительность: {scheduledTask.Task.EstimatedMinutes} мин";
                listBoxSchedule.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _tasks.Clear();
            _nextId = 1;
            dataGridViewTasks.Rows.Clear();
            listBoxSchedule.Items.Clear();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            listBoxSchedule.Items.Clear();
            listBoxSchedule.Items.Add("=== ТЕСТ ПРОИЗВОДИТЕЛЬНОСТИ ===");
            listBoxSchedule.Items.Add("");

            var sizes = new[] { 10, 100, 1000, 5000 };
            var random = new Random(42);

            foreach (var size in sizes)
            {
                var testTasks = new List<TaskItem>();
                for (int i = 0; i < size; i++)
                {
                    testTasks.Add(new TaskItem
                    {
                        Id = i,
                        Title = $"Task_{i}",
                        Priority = (Priority)random.Next(1, 5),
                        EstimatedMinutes = random.Next(5, 60)
                    });
                }

                var stopwatch = Stopwatch.StartNew();
                var scheduler = new TaskManager.Algorithms.TaskScheduler();
                var schedule = scheduler.ScheduleTasks(testTasks);
                stopwatch.Stop();

                listBoxSchedule.Items.Add($"N = {size,5} задач → {stopwatch.ElapsedMilliseconds,4} мс");
            }

            listBoxSchedule.Items.Add("");
            listBoxSchedule.Items.Add("Тест завершён!");
        }
    }
}