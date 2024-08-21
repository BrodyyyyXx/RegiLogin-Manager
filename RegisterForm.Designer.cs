namespace WinFormsApp1
{
    partial class RegisterForm
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
            panel1 = new Panel();
            userSurnameField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passField = new TextBox();
            loginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            registerLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 8, 24);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 476);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userSurnameField.Location = new Point(474, 194);
            userSurnameField.Margin = new Padding(3, 2, 3, 2);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(323, 49);
            userSurnameField.TabIndex = 5;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameField.Location = new Point(62, 194);
            userNameField.Margin = new Padding(3, 2, 3, 2);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(323, 49);
            userNameField.TabIndex = 4;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(37, 117, 43);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 48, 8);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 61, 7);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(265, 361);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(258, 48);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Зарегестрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(474, 271);
            passField.Margin = new Padding(3, 2, 3, 2);
            passField.Name = "passField";
            passField.Size = new Size(323, 47);
            passField.TabIndex = 2;
            passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(62, 271);
            loginField.Margin = new Padding(3, 2, 3, 2);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(323, 49);
            loginField.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(412, 271);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(0, 271);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 24, 70);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 94);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(775, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(239, 239, 239);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 94);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerLabel.ForeColor = Color.White;
            registerLabel.Location = new Point(337, 435);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(104, 13);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "Авторизоваться";
            registerLabel.Click += registerLabel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private TextBox passField;
        private TextBox loginField;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private Label registerLabel;
    }
}