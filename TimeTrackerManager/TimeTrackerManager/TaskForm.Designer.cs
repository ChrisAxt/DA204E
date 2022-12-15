namespace TimeTrackerManager
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxNewTask = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.cbxTaskType = new System.Windows.Forms.ComboBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblAllocatedTime = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.gbxNewTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNewTask
            // 
            this.gbxNewTask.Controls.Add(this.dateTimePicker1);
            this.gbxNewTask.Controls.Add(this.label1);
            this.gbxNewTask.Controls.Add(this.btnCancel);
            this.gbxNewTask.Controls.Add(this.btnAdd);
            this.gbxNewTask.Controls.Add(this.lblMin);
            this.gbxNewTask.Controls.Add(this.txtMin);
            this.gbxNewTask.Controls.Add(this.lblHour);
            this.gbxNewTask.Controls.Add(this.txtHour);
            this.gbxNewTask.Controls.Add(this.cbxTaskType);
            this.gbxNewTask.Controls.Add(this.txtTaskDescription);
            this.gbxNewTask.Controls.Add(this.lblAllocatedTime);
            this.gbxNewTask.Controls.Add(this.lblTaskType);
            this.gbxNewTask.Controls.Add(this.lblTaskDescription);
            this.gbxNewTask.Location = new System.Drawing.Point(12, 12);
            this.gbxNewTask.Name = "gbxNewTask";
            this.gbxNewTask.Size = new System.Drawing.Size(516, 211);
            this.gbxNewTask.TabIndex = 0;
            this.gbxNewTask.TabStop = false;
            this.gbxNewTask.Text = "Add New Task";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 59);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 29, 14, 43, 56, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date ";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(292, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(200, 125);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 13);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "Min:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(230, 121);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(38, 20);
            this.txtMin.TabIndex = 5;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(127, 125);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(26, 13);
            this.lblHour.TabIndex = 6;
            this.lblHour.Text = "Hrs:";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(156, 121);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(38, 20);
            this.txtHour.TabIndex = 4;
            // 
            // cbxTaskType
            // 
            this.cbxTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTaskType.FormattingEnabled = true;
            this.cbxTaskType.Location = new System.Drawing.Point(130, 90);
            this.cbxTaskType.Name = "cbxTaskType";
            this.cbxTaskType.Size = new System.Drawing.Size(138, 21);
            this.cbxTaskType.TabIndex = 3;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(130, 28);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(373, 20);
            this.txtTaskDescription.TabIndex = 1;
            // 
            // lblAllocatedTime
            // 
            this.lblAllocatedTime.AutoSize = true;
            this.lblAllocatedTime.Location = new System.Drawing.Point(23, 124);
            this.lblAllocatedTime.Name = "lblAllocatedTime";
            this.lblAllocatedTime.Size = new System.Drawing.Size(77, 13);
            this.lblAllocatedTime.TabIndex = 2;
            this.lblAllocatedTime.Text = "Allocated Time";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(23, 93);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(54, 13);
            this.lblTaskType.TabIndex = 1;
            this.lblTaskType.Text = "Task type";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(23, 31);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(85, 13);
            this.lblTaskDescription.TabIndex = 0;
            this.lblTaskDescription.Text = "Task description";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 234);
            this.Controls.Add(this.gbxNewTask);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.gbxNewTask.ResumeLayout(false);
            this.gbxNewTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNewTask;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cbxTaskType;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblAllocatedTime;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}