namespace TestProject
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cmbRole = new ComboBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            dgvUserList = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 430);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Provide  All The Fields";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User", "Admin" });
            cmbRole.Location = new Point(361, 300);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(600, 45);
            cmbRole.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(361, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(600, 45);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(361, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(600, 45);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(361, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(600, 45);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 308);
            label4.Name = "label4";
            label4.Size = new Size(94, 37);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 238);
            label3.Name = "label3";
            label3.Size = new Size(306, 37);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 169);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 107);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(51, 550);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(209, 46);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(290, 550);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 46);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(535, 550);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(779, 550);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(209, 46);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvUserList);
            panel1.Location = new Point(12, 613);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 255);
            panel1.TabIndex = 5;
            // 
            // dgvUserList
            // 
            dgvUserList.AllowUserToAddRows = false;
            dgvUserList.AllowUserToDeleteRows = false;
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Dock = DockStyle.Fill;
            dgvUserList.Location = new Point(0, 0);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserList.RowHeadersWidth = 82;
            dgvUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserList.Size = new Size(1204, 255);
            dgvUserList.TabIndex = 0;
            dgvUserList.CellClick += dgvUserList_CellClick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 894);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel1;
        private DataGridView dgvUserList;
    }
}