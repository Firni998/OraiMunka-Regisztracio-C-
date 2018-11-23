namespace MysqlApplication
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
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.JelszoTextBox = new System.Windows.Forms.TextBox();
            this.DateTimeTicker = new System.Windows.Forms.DateTimePicker();
            this.Reg_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NevTextBox
            // 
            this.NevTextBox.Location = new System.Drawing.Point(38, 25);
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(200, 20);
            this.NevTextBox.TabIndex = 0;
            // 
            // JelszoTextBox
            // 
            this.JelszoTextBox.Location = new System.Drawing.Point(38, 51);
            this.JelszoTextBox.Name = "JelszoTextBox";
            this.JelszoTextBox.PasswordChar = '*';
            this.JelszoTextBox.Size = new System.Drawing.Size(200, 20);
            this.JelszoTextBox.TabIndex = 1;
            // 
            // DateTimeTicker
            // 
            this.DateTimeTicker.Location = new System.Drawing.Point(38, 77);
            this.DateTimeTicker.Name = "DateTimeTicker";
            this.DateTimeTicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimeTicker.TabIndex = 2;
            // 
            // Reg_Button
            // 
            this.Reg_Button.Location = new System.Drawing.Point(163, 103);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(75, 23);
            this.Reg_Button.TabIndex = 3;
            this.Reg_Button.Text = "Regisztráció";
            this.Reg_Button.UseVisualStyleBackColor = true;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regisztráció";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reg_Button);
            this.Controls.Add(this.DateTimeTicker);
            this.Controls.Add(this.JelszoTextBox);
            this.Controls.Add(this.NevTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.TextBox JelszoTextBox;
        private System.Windows.Forms.DateTimePicker DateTimeTicker;
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.Label label1;
    }
}

