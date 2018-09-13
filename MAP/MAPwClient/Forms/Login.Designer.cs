namespace MAPwClient
{
    partial class Login
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
            this.loginBtns_grpBx = new System.Windows.Forms.GroupBox();
            this.loginInfo_grpBx = new System.Windows.Forms.GroupBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_txtBx = new System.Windows.Forms.TextBox();
            this.password_txtBx = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.loginBtns_grpBx.SuspendLayout();
            this.loginInfo_grpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtns_grpBx
            // 
            this.loginBtns_grpBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtns_grpBx.Controls.Add(this.login_btn);
            this.loginBtns_grpBx.Location = new System.Drawing.Point(296, 338);
            this.loginBtns_grpBx.Name = "loginBtns_grpBx";
            this.loginBtns_grpBx.Size = new System.Drawing.Size(200, 100);
            this.loginBtns_grpBx.TabIndex = 0;
            this.loginBtns_grpBx.TabStop = false;
            // 
            // loginInfo_grpBx
            // 
            this.loginInfo_grpBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInfo_grpBx.Controls.Add(this.password_txtBx);
            this.loginInfo_grpBx.Controls.Add(this.username_txtBx);
            this.loginInfo_grpBx.Controls.Add(this.password_lbl);
            this.loginInfo_grpBx.Controls.Add(this.username_lbl);
            this.loginInfo_grpBx.Location = new System.Drawing.Point(296, 105);
            this.loginInfo_grpBx.Name = "loginInfo_grpBx";
            this.loginInfo_grpBx.Size = new System.Drawing.Size(200, 167);
            this.loginInfo_grpBx.TabIndex = 1;
            this.loginInfo_grpBx.TabStop = false;
            this.loginInfo_grpBx.UseCompatibleTextRendering = true;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(6, 16);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(58, 13);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(6, 87);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(56, 13);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password:";
            // 
            // username_txtBx
            // 
            this.username_txtBx.Location = new System.Drawing.Point(9, 47);
            this.username_txtBx.Name = "username_txtBx";
            this.username_txtBx.Size = new System.Drawing.Size(185, 20);
            this.username_txtBx.TabIndex = 2;
            // 
            // password_txtBx
            // 
            this.password_txtBx.Location = new System.Drawing.Point(7, 120);
            this.password_txtBx.Name = "password_txtBx";
            this.password_txtBx.Size = new System.Drawing.Size(187, 20);
            this.password_txtBx.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_btn.Location = new System.Drawing.Point(60, 19);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginInfo_grpBx);
            this.Controls.Add(this.loginBtns_grpBx);
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.loginBtns_grpBx.ResumeLayout(false);
            this.loginInfo_grpBx.ResumeLayout(false);
            this.loginInfo_grpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBtns_grpBx;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.GroupBox loginInfo_grpBx;
        private System.Windows.Forms.TextBox password_txtBx;
        private System.Windows.Forms.TextBox username_txtBx;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
    }
}

