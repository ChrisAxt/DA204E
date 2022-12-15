namespace TimeTrackerManager
{
    partial class Settings
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName2Hours = new System.Windows.Forms.TextBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.txtName3Hours = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblRelaxation = new System.Windows.Forms.Label();
            this.txtName1Hours = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtName2Hours);
            this.groupBox4.Controls.Add(this.lblPersonal);
            this.groupBox4.Controls.Add(this.txtName3Hours);
            this.groupBox4.Controls.Add(this.lblWork);
            this.groupBox4.Controls.Add(this.lblRelaxation);
            this.groupBox4.Controls.Add(this.txtName1Hours);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 150);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Allocation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours ";
            // 
            // txtName2Hours
            // 
            this.txtName2Hours.Location = new System.Drawing.Point(119, 85);
            this.txtName2Hours.Name = "txtName2Hours";
            this.txtName2Hours.Size = new System.Drawing.Size(41, 20);
            this.txtName2Hours.TabIndex = 4;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(8, 56);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(48, 13);
            this.lblPersonal.TabIndex = 0;
            this.lblPersonal.Text = "Personal";
            // 
            // txtName3Hours
            // 
            this.txtName3Hours.Location = new System.Drawing.Point(119, 117);
            this.txtName3Hours.Name = "txtName3Hours";
            this.txtName3Hours.Size = new System.Drawing.Size(41, 20);
            this.txtName3Hours.TabIndex = 5;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(8, 88);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(33, 13);
            this.lblWork.TabIndex = 1;
            this.lblWork.Text = "Work";
            // 
            // lblRelaxation
            // 
            this.lblRelaxation.AutoSize = true;
            this.lblRelaxation.Location = new System.Drawing.Point(8, 120);
            this.lblRelaxation.Name = "lblRelaxation";
            this.lblRelaxation.Size = new System.Drawing.Size(57, 13);
            this.lblRelaxation.TabIndex = 2;
            this.lblRelaxation.Text = "Relaxation";
            // 
            // txtName1Hours
            // 
            this.txtName1Hours.Location = new System.Drawing.Point(119, 53);
            this.txtName1Hours.Name = "txtName1Hours";
            this.txtName1Hours.Size = new System.Drawing.Size(41, 20);
            this.txtName1Hours.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(82, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(12, 170);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(55, 23);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click_1);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 202);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Name = "Settings";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName3Hours;
        private System.Windows.Forms.TextBox txtName2Hours;
        private System.Windows.Forms.TextBox txtName1Hours;
        private System.Windows.Forms.Label lblRelaxation;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDefault;
    }
}