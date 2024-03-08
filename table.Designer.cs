namespace WinFormsApp1
{
    partial class table
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
            this.btn_ex = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(428, 364);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(94, 29);
            this.btn_ex.TabIndex = 0;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            this.btn_ex.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_connect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bt_connect.Location = new System.Drawing.Point(208, 355);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(94, 29);
            this.bt_connect.TabIndex = 12;
            this.bt_connect.Text = "save";
            this.bt_connect.UseVisualStyleBackColor = false;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spécialité";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(250, 245);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(253, 27);
            this.txt_password.TabIndex = 10;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(250, 163);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(253, 27);
            this.txt_login.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Spécialté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ex);
            this.Name = "table";
            this.Text = "table";
            this.Load += new System.EventHandler(this.table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ex;
        private Button bt_connect;
        private Label label3;
        private TextBox txt_password;
        private TextBox txt_login;
        private Label label2;
        private Label label1;
    }
}