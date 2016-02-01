namespace Coach_Program
{
    partial class Add_Client
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtBoxInsertName = new System.Windows.Forms.TextBox();
            this.txtBoxInsertDate = new System.Windows.Forms.TextBox();
            this.txtBoxInsertCycle = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.Label();
            this.selectDate = new System.Windows.Forms.Label();
            this.cycleLenght = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(274, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateSelectedFunc);
            // 
            // txtBoxInsertName
            // 
            this.txtBoxInsertName.Location = new System.Drawing.Point(73, 18);
            this.txtBoxInsertName.Name = "txtBoxInsertName";
            this.txtBoxInsertName.Size = new System.Drawing.Size(165, 20);
            this.txtBoxInsertName.TabIndex = 1;
            // 
            // txtBoxInsertDate
            // 
            this.txtBoxInsertDate.Location = new System.Drawing.Point(73, 59);
            this.txtBoxInsertDate.Name = "txtBoxInsertDate";
            this.txtBoxInsertDate.ReadOnly = true;
            this.txtBoxInsertDate.Size = new System.Drawing.Size(165, 20);
            this.txtBoxInsertDate.TabIndex = 2;
            // 
            // txtBoxInsertCycle
            // 
            this.txtBoxInsertCycle.Location = new System.Drawing.Point(73, 100);
            this.txtBoxInsertCycle.Name = "txtBoxInsertCycle";
            this.txtBoxInsertCycle.Size = new System.Drawing.Size(165, 20);
            this.txtBoxInsertCycle.TabIndex = 3;
            // 
            // addName
            // 
            this.addName.AutoSize = true;
            this.addName.Location = new System.Drawing.Point(10, 21);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(57, 13);
            this.addName.TabIndex = 4;
            this.addName.Text = "Add Name";
            // 
            // selectDate
            // 
            this.selectDate.AutoSize = true;
            this.selectDate.Location = new System.Drawing.Point(4, 62);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(63, 13);
            this.selectDate.TabIndex = 5;
            this.selectDate.Text = "Select Date";
            // 
            // cycleLenght
            // 
            this.cycleLenght.AutoSize = true;
            this.cycleLenght.Location = new System.Drawing.Point(-2, 103);
            this.cycleLenght.Name = "cycleLenght";
            this.cycleLenght.Size = new System.Drawing.Size(69, 13);
            this.cycleLenght.TabIndex = 6;
            this.cycleLenght.Text = "Cycle Lenght";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddClientFunc);
            // 
            // Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 193);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cycleLenght);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.txtBoxInsertCycle);
            this.Controls.Add(this.txtBoxInsertDate);
            this.Controls.Add(this.txtBoxInsertName);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Add_Client";
            this.Text = "Add_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txtBoxInsertName;
        private System.Windows.Forms.TextBox txtBoxInsertDate;
        private System.Windows.Forms.TextBox txtBoxInsertCycle;
        private System.Windows.Forms.Label addName;
        private System.Windows.Forms.Label selectDate;
        private System.Windows.Forms.Label cycleLenght;
        private System.Windows.Forms.Button btnAdd;
    }
}