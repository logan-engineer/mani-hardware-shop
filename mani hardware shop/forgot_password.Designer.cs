namespace mani_hardware_shop
{
    partial class forgot_password
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
            components = new System.ComponentModel.Container();
            btn_Send = new Button();
            label1 = new Label();
            txt_Email = new TextBox();
            txt_Otp = new TextBox();
            btn_Verify = new Button();
            txt_Username = new TextBox();
            lbl_Username = new Label();
            txt_Password = new TextBox();
            lbl_password = new Label();
            btn_Update = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.Cyan;
            btn_Send.Location = new Point(568, 149);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(94, 44);
            btn_Send.TabIndex = 0;
            btn_Send.Text = "Send OTP";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_OTP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 158);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Location = new Point(270, 158);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(227, 27);
            txt_Email.TabIndex = 2;
            txt_Email.TextChanged += txt_Email_TextChanged;
            // 
            // txt_Otp
            // 
            txt_Otp.BorderStyle = BorderStyle.FixedSingle;
            txt_Otp.Location = new Point(270, 224);
            txt_Otp.Name = "txt_Otp";
            txt_Otp.Size = new Size(227, 27);
            txt_Otp.TabIndex = 3;
            // 
            // btn_Verify
            // 
            btn_Verify.BackColor = Color.Green;
            btn_Verify.Location = new Point(568, 216);
            btn_Verify.Name = "btn_Verify";
            btn_Verify.Size = new Size(94, 44);
            btn_Verify.TabIndex = 4;
            btn_Verify.Text = "Verify";
            btn_Verify.UseVisualStyleBackColor = false;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.FixedSingle;
            txt_Username.Location = new Point(270, 160);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(227, 27);
            txt_Username.TabIndex = 5;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(180, 158);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(73, 20);
            lbl_Username.TabIndex = 6;
            lbl_Username.Text = "username";
            // 
            // txt_Password
            // 
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Location = new Point(270, 224);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(227, 27);
            txt_Password.TabIndex = 7;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(152, 231);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(101, 20);
            lbl_password.TabIndex = 8;
            lbl_password.Text = "new Password";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(192, 192, 0);
            btn_Update.Location = new Point(338, 280);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 41);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click_1;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = this;
            // 
            // forgot_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Update);
            Controls.Add(lbl_password);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Username);
            Controls.Add(txt_Username);
            Controls.Add(btn_Verify);
            Controls.Add(txt_Otp);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Controls.Add(btn_Send);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forgot_password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forgot_password";
            Load += forgot_password_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Send;
        private Label label1;
        private TextBox txt_Email;
        private TextBox txt_Otp;
        private Button btn_Verify;
        private TextBox txt_Username;
        private Label lbl_Username;
        private TextBox txt_Password;
        private Label lbl_password;
        private Button btn_Update;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}