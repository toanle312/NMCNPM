using System.Windows.Forms.VisualStyles;

namespace GUI
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.loginButton = new System.Windows.Forms.Button();
            this.exitPTB = new System.Windows.Forms.PictureBox();
            this.backgroundPTB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new GUI.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPTB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AllowDrop = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(563, 547);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(487, 60);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitPTB
            // 
            this.exitPTB.BackColor = System.Drawing.Color.Transparent;
            this.exitPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPTB.Image = global::GUI.Properties.Resources.exit;
            this.exitPTB.Location = new System.Drawing.Point(1038, 12);
            this.exitPTB.Name = "exitPTB";
            this.exitPTB.Size = new System.Drawing.Size(30, 30);
            this.exitPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPTB.TabIndex = 1;
            this.exitPTB.TabStop = false;
            this.exitPTB.WaitOnLoad = true;
            this.exitPTB.Click += new System.EventHandler(this.exitPTB_Click);
            // 
            // backgroundPTB
            // 
            this.backgroundPTB.Image = global::GUI.Properties.Resources.login;
            this.backgroundPTB.Location = new System.Drawing.Point(0, 0);
            this.backgroundPTB.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundPTB.Name = "backgroundPTB";
            this.backgroundPTB.Size = new System.Drawing.Size(540, 720);
            this.backgroundPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPTB.TabIndex = 2;
            this.backgroundPTB.TabStop = false;
            this.backgroundPTB.Click += new System.EventHandler(this.backgroundPTB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(563, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(563, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "ONENIGHT Hotel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(687, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(563, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(563, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(883, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quên mật khẩu ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox4.BorderSize = 2;
            this.textBox4.Location = new System.Drawing.Point(563, 421);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Padding = new System.Windows.Forms.Padding(20);
            this.textBox4.Size = new System.Drawing.Size(0, 0);
            this.textBox4.TabIndex = 12;
            this.textBox4.UnderlinedStyle = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(481, 27);
            this.userNameTextBox.TabIndex = 15;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTextBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(563, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 59);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.passWordTextBox);
            this.panel2.Location = new System.Drawing.Point(563, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 59);
            this.panel2.TabIndex = 17;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWordTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passWordTextBox.Location = new System.Drawing.Point(3, 16);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(481, 27);
            this.passWordTextBox.TabIndex = 16;
            this.passWordTextBox.TextChanged += new System.EventHandler(this.passWordTextBox_TextChanged);
            this.passWordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWordTextBox_KeyDown);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPass.Location = new System.Drawing.Point(566, 491);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(192, 28);
            this.showPass.TabIndex = 18;
            this.showPass.Text = "Hiển thị mật khẩu";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundPTB);
            this.Controls.Add(this.exitPTB);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPTB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private PictureBox exitPTB;
        private PictureBox backgroundPTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.TextBox passWordTextBox;
        private CheckBox showPass;
        private PictureBox pictureBox1;
    }
}