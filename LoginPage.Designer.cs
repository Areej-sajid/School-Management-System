namespace Student_Management_System
{
    partial class LoginPage
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
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSeaGreen;
            btnLogin.Location = new Point(113, 642);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(205, 53);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LogIn";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school_logo;
            pictureBox1.Location = new Point(74, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 335);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 462);
            label2.Name = "label2";
            label2.Size = new Size(124, 35);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(59, 391);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(59, 524);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(1198, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 758);
            panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(135, 593);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(150, 709);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1189, 55);
            label3.Name = "label3";
            label3.Size = new Size(476, 52);
            label3.TabIndex = 7;
            label3.Text = "Login to your Account";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.design;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(969, 1059);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(384, 161);
            label4.Name = "label4";
            label4.Size = new Size(197, 54);
            label4.TabIndex = 9;
            label4.Text = "Welcome";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "LoginPage";
            Text = "Form1";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}
