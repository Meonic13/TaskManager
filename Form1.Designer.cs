namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblMinutes = new Label();
            nudMinutes = new NumericUpDown();
            btnAdd = new Button();
            dataGridViewTasks = new DataGridView();
            btnSchedule = new Button();
            btnClear = new Button();
            btnBenchmark = new Button();
            listBoxSchedule = new ListBox();
            lblSchedule = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(22, 32);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название задачи:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(28, 70);
            txtTitle.Margin = new Padding(6, 6, 6, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(368, 39);
            txtTitle.TabIndex = 1;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(427, 32);
            lblPriority.Margin = new Padding(6, 0, 6, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(139, 32);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "Приоритет:";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.Location = new Point(433, 70);
            cmbPriority.Margin = new Padding(6, 6, 6, 6);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(182, 40);
            cmbPriority.TabIndex = 3;
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(641, 32);
            lblMinutes.Margin = new Padding(6, 0, 6, 0);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(155, 32);
            lblMinutes.TabIndex = 4;
            lblMinutes.Text = "Время (мин):";
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(646, 70);
            nudMinutes.Margin = new Padding(6, 6, 6, 6);
            nudMinutes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(149, 39);
            nudMinutes.TabIndex = 5;
            nudMinutes.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(826, 66);
            btnAdd.Margin = new Padding(6, 6, 6, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(223, 53);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить задачу";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(28, 149);
            dataGridViewTasks.Margin = new Padding(6, 6, 6, 6);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.Size = new Size(1021, 427);
            dataGridViewTasks.TabIndex = 7;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(28, 608);
            btnSchedule.Margin = new Padding(6, 6, 6, 6);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(279, 64);
            btnSchedule.TabIndex = 8;
            btnSchedule.Text = "Спланировать задачи";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(334, 608);
            btnClear.Margin = new Padding(6, 6, 6, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(186, 64);
            btnClear.TabIndex = 9;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBenchmark
            // 
            btnBenchmark.Location = new Point(548, 608);
            btnBenchmark.Margin = new Padding(6, 6, 6, 6);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(279, 64);
            btnBenchmark.TabIndex = 10;
            btnBenchmark.Text = "Тест производительности";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // listBoxSchedule
            // 
            listBoxSchedule.FormattingEnabled = true;
            listBoxSchedule.Location = new Point(28, 704);
            listBoxSchedule.Margin = new Padding(6, 6, 6, 6);
            listBoxSchedule.Name = "listBoxSchedule";
            listBoxSchedule.Size = new Size(1018, 324);
            listBoxSchedule.TabIndex = 11;
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(28, 666);
            lblSchedule.Margin = new Padding(6, 0, 6, 0);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(216, 32);
            lblSchedule.TabIndex = 12;
            lblSchedule.Text = "Расписание задач:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2086, 1067);
            Controls.Add(lblSchedule);
            Controls.Add(listBoxSchedule);
            Controls.Add(btnBenchmark);
            Controls.Add(btnClear);
            Controls.Add(btnSchedule);
            Controls.Add(dataGridViewTasks);
            Controls.Add(btnAdd);
            Controls.Add(nudMinutes);
            Controls.Add(lblMinutes);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Система управления задачами с приоритетами";
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Label lblSchedule;
    }
}