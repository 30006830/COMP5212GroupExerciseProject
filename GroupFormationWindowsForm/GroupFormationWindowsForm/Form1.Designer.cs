namespace GroupFormationWindowsForm
{
    partial class Form1
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
            this.GroupName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.BankAccNo = new System.Windows.Forms.Label();
            this.IRDNo = new System.Windows.Forms.Label();
            this.PayPerHr = new System.Windows.Forms.Label();
            this.HoursWorked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.Location = new System.Drawing.Point(12, 9);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(209, 42);
            this.GroupName.TabIndex = 0;
            this.GroupName.Text = "Group Formation";
            this.GroupName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 38);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(19, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 38);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(19, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(385, 38);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(19, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(385, 38);
            this.textBox4.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(19, 308);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(385, 38);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(19, 365);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(385, 38);
            this.textBox7.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(19, 61);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 8;
            this.Name.Text = "Name";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(19, 121);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 9;
            this.Age.Text = "Age";
            // 
            // BankAccNo
            // 
            this.BankAccNo.AutoSize = true;
            this.BankAccNo.Location = new System.Drawing.Point(19, 178);
            this.BankAccNo.Name = "BankAccNo";
            this.BankAccNo.Size = new System.Drawing.Size(95, 13);
            this.BankAccNo.TabIndex = 10;
            this.BankAccNo.Text = "Bank Account No:";
            this.BankAccNo.Click += new System.EventHandler(this.label4_Click);
            // 
            // IRDNo
            // 
            this.IRDNo.AutoSize = true;
            this.IRDNo.Location = new System.Drawing.Point(19, 235);
            this.IRDNo.Name = "IRDNo";
            this.IRDNo.Size = new System.Drawing.Size(46, 13);
            this.IRDNo.TabIndex = 11;
            this.IRDNo.Text = "IRD No:";
            // 
            // PayPerHr
            // 
            this.PayPerHr.AutoSize = true;
            this.PayPerHr.Location = new System.Drawing.Point(19, 292);
            this.PayPerHr.Name = "PayPerHr";
            this.PayPerHr.Size = new System.Drawing.Size(67, 13);
            this.PayPerHr.TabIndex = 12;
            this.PayPerHr.Text = "Pay (Per Hr):";
            // 
            // HoursWorked
            // 
            this.HoursWorked.AutoSize = true;
            this.HoursWorked.Location = new System.Drawing.Point(19, 349);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(79, 13);
            this.HoursWorked.TabIndex = 13;
            this.HoursWorked.Text = "Hours Worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 640);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.PayPerHr);
            this.Controls.Add(this.IRDNo);
            this.Controls.Add(this.BankAccNo);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GroupName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label BankAccNo;
        private System.Windows.Forms.Label IRDNo;
        private System.Windows.Forms.Label PayPerHr;
        private System.Windows.Forms.Label HoursWorked;
    }
}

