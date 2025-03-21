namespace Student_Management_System
{
    partial class MainDashboard
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
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(452, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 855);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 855);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Turquoise;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(953, 855);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school_logo;
            pictureBox1.Location = new Point(336, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(670, 567);
            button5.Name = "button5";
            button5.Size = new Size(241, 191);
            button5.TabIndex = 4;
            button5.Text = "Accountant";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(370, 567);
            button4.Name = "button4";
            button4.Size = new Size(241, 191);
            button4.TabIndex = 3;
            button4.Text = "Teacher";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(70, 567);
            button3.Name = "button3";
            button3.Size = new Size(241, 191);
            button3.TabIndex = 2;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(243, 426);
            label5.Name = "label5";
            label5.Size = new Size(522, 70);
            label5.TabIndex = 1;
            label5.Text = "Knowledge House";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(198, 356);
            label6.Name = "label6";
            label6.Size = new Size(608, 70);
            label6.TabIndex = 0;
            label6.Text = "Welcome To Al Hamd";
            // 
            // button2
            // 
            button2.Location = new Point(72, 567);
            button2.Name = "button2";
            button2.Size = new Size(241, 191);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(221, 386);
            label3.Name = "label3";
            label3.Size = new Size(544, 81);
            label3.TabIndex = 1;
            label3.Text = "Knowledge House";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(176, 289);
            label4.Name = "label4";
            label4.Size = new Size(642, 81);
            label4.TabIndex = 0;
            label4.Text = "Welcome To Al Hamd";
            // 
            // button1
            // 
            button1.Location = new Point(72, 567);
            button1.Name = "button1";
            button1.Size = new Size(241, 191);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(221, 386);
            label2.Name = "label2";
            label2.Size = new Size(544, 81);
            label2.TabIndex = 1;
            label2.Text = "Knowledge House";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 289);
            label1.Name = "label1";
            label1.Size = new Size(642, 81);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Al Hamd";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 855);
            Controls.Add(panel1);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainDashboard";
            WindowState = FormWindowState.Maximized;
            Load += MainDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}