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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.list_box = new System.Windows.Forms.ListBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
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
            this.Reg_Button.Location = new System.Drawing.Point(94, 103);
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
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(94, 161);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Kilépés";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(94, 132);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Belépés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // list_box
            // 
            this.list_box.FormattingEnabled = true;
            this.list_box.Location = new System.Drawing.Point(50, 190);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(174, 121);
            this.list_box.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(50, 317);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Frissités";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(149, 317);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Törlés";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 396);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.list_box);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_logout);
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
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ListBox list_box;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}

