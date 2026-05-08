using System;
using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.Algorithms
{
    public class ScheduledTask
    {
        public TaskItem Task { get; set; } = null!;
        public int StartMinute { get; set; }
        public int EndMinute { get; set; }
    }

    public class TaskScheduler
    {
        public List<ScheduledTask> ScheduleTasks(IEnumerable<TaskItem> tasks)
        {
            if (tasks == null)
                throw new ArgumentNullException(nameof(tasks));

            var queue = new MaxHeapPriorityQueue();
            foreach (var task in tasks)
                queue.Enqueue(task);

            var schedule = new List<ScheduledTask>();
            int currentTime = 0;

            while (queue.Count > 0)
            {
                var task = queue.Dequeue();
                var scheduled = new ScheduledTask
                {
                    Task = task,
                    StartMinute = currentTime,
                    EndMinute = currentTime + task.EstimatedMinutes
                };
                schedule.Add(scheduled);
                currentTime = scheduled.EndMinute;
            }
            return schedule;
        }
    }
}