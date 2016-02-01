namespace Coach_Program
{
    partial class Update_User
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxCycle = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.brnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(73, 18);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(165, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.Text = name;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(73, 59);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.ReadOnly = true;
            this.txtBoxDate.Size = new System.Drawing.Size(165, 20);
            this.txtBoxDate.TabIndex = 2;
            this.txtBoxDate.Text = date;
            // 
            // txtBoxCycle
            // 
            this.txtBoxCycle.Location = new System.Drawing.Point(73, 100);
            this.txtBoxCycle.Name = "txtBoxCycle";
            this.txtBoxCycle.Size = new System.Drawing.Size(165, 20);
            this.txtBoxCycle.TabIndex = 3;
            this.txtBoxCycle.Text = cyc.ToString();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(32, 62);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(-2, 103);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(69, 13);
            this.lblCycle.TabIndex = 5;
            this.lblCycle.Text = "Cycle Lenght";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(274, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // brnUpdate
            // 
            this.brnUpdate.Location = new System.Drawing.Point(73, 140);
            this.brnUpdate.Name = "brnUpdate";
            this.brnUpdate.Size = new System.Drawing.Size(165, 40);
            this.brnUpdate.TabIndex = 7;
            this.brnUpdate.Text = "Update";
            this.brnUpdate.UseVisualStyleBackColor = true;
            this.brnUpdate.Click += new System.EventHandler(this.brnUpdate_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 193);
            this.Controls.Add(this.brnUpdate);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBoxCycle);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.TextBox txtBoxCycle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button brnUpdate;
    }
}