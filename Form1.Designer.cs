namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(218, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Provide Username And Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(418, 45);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(235, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(418, 45);
            txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 112);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(218, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(282, 76);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 420);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(282, 76);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 642);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login System";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private Button btnExit;
    }
}
