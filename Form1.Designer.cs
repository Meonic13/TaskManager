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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название задачи:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(230, 15);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(60, 15);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Приоритет:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            this.cmbPriority.Location = new System.Drawing.Point(233, 33);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(100, 23);
            this.cmbPriority.TabIndex = 3;
            this.cmbPriority.SelectedIndex = 1;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(345, 15);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(75, 15);
            this.lblMinutes.TabIndex = 4;
            this.lblMinutes.Text = "Время (мин):";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(348, 33);
            this.nudMinutes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(80, 23);
            this.nudMinutes.TabIndex = 5;
            this.nudMinutes.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить задачу";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(15, 70);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.Size = new System.Drawing.Size(550, 200);
            this.dataGridViewTasks.TabIndex = 7;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(15, 285);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(150, 30);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Спланировать задачи";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Location = new System.Drawing.Point(295, 285);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(150, 30);
            this.btnBenchmark.TabIndex = 10;
            this.btnBenchmark.Text = "Тест производительности";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.ItemHeight = 15;
            this.listBoxSchedule.Location = new System.Drawing.Point(15, 330);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(550, 154);
            this.listBoxSchedule.TabIndex = 11;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(15, 312);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(120, 15);
            this.lblSchedule.TabIndex = 12;
            this.lblSchedule.Text = "Расписание задач:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 500);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.btnBenchmark);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Система управления задачами с приоритетами";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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