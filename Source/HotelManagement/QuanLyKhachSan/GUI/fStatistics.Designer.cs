namespace GUI
{
    partial class fStatistics
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ThongKeTheoDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThongKeTheoMatDoSuDung = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1045, 121);
            this.toppanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.thongke;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ThongKeTheoDoanhThu
            // 
            this.btn_ThongKeTheoDoanhThu.BackgroundImage = global::GUI.Properties.Resources.report1;
            this.btn_ThongKeTheoDoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeTheoDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThongKeTheoDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeTheoDoanhThu.Location = new System.Drawing.Point(28, 153);
            this.btn_ThongKeTheoDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKeTheoDoanhThu.Name = "btn_ThongKeTheoDoanhThu";
            this.btn_ThongKeTheoDoanhThu.Size = new System.Drawing.Size(391, 362);
            this.btn_ThongKeTheoDoanhThu.TabIndex = 2;
            this.btn_ThongKeTheoDoanhThu.UseVisualStyleBackColor = true;
            this.btn_ThongKeTheoDoanhThu.Click += new System.EventHandler(this.btn_ThongKeTheoDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 558);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê doanh thu theo loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(559, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thống kê theo mật độ sử dụng phòng";
            // 
            // btn_ThongKeTheoMatDoSuDung
            // 
            this.btn_ThongKeTheoMatDoSuDung.BackgroundImage = global::GUI.Properties.Resources.report1;
            this.btn_ThongKeTheoMatDoSuDung.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeTheoMatDoSuDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThongKeTheoMatDoSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeTheoMatDoSuDung.Location = new System.Drawing.Point(592, 153);
            this.btn_ThongKeTheoMatDoSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKeTheoMatDoSuDung.Name = "btn_ThongKeTheoMatDoSuDung";
            this.btn_ThongKeTheoMatDoSuDung.Size = new System.Drawing.Size(386, 362);
            this.btn_ThongKeTheoMatDoSuDung.TabIndex = 4;
            this.btn_ThongKeTheoMatDoSuDung.UseVisualStyleBackColor = true;
            this.btn_ThongKeTheoMatDoSuDung.Click += new System.EventHandler(this.btn_ThongKeTheoMatDoSuDung_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(881, 607);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 42);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Đóng";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1045, 673);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btn_ThongKeTheoMatDoSuDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ThongKeTheoDoanhThu);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fStatistics";
            this.Text = "fStatistics";
            this.Load += new System.EventHandler(this.fStatistics_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel toppanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_ThongKeTheoDoanhThu;
        private Label label2;
        private Label label3;
        private Button btn_ThongKeTheoMatDoSuDung;
        private Button closeButton;
    }
}