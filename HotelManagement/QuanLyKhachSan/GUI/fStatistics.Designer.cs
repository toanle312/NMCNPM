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
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ThongKeTheoDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThongKeTheoMatDoSuDung = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.toppanel.Controls.Add(this.btn_QuayLai);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1306, 151);
            this.toppanel.TabIndex = 1;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QuayLai.Image = global::GUI.Properties.Resources.return4;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(1107, 57);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(199, 58);
            this.btn_QuayLai.TabIndex = 1;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.thongke;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ThongKeTheoDoanhThu
            // 
            this.btn_ThongKeTheoDoanhThu.BackgroundImage = global::GUI.Properties.Resources.report1;
            this.btn_ThongKeTheoDoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeTheoDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThongKeTheoDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeTheoDoanhThu.Location = new System.Drawing.Point(36, 207);
            this.btn_ThongKeTheoDoanhThu.Name = "btn_ThongKeTheoDoanhThu";
            this.btn_ThongKeTheoDoanhThu.Size = new System.Drawing.Size(455, 452);
            this.btn_ThongKeTheoDoanhThu.TabIndex = 2;
            this.btn_ThongKeTheoDoanhThu.UseVisualStyleBackColor = true;
            this.btn_ThongKeTheoDoanhThu.Click += new System.EventHandler(this.btn_ThongKeTheoDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê doanh thu theo loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(699, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thống kê theo mật độ sử dụng phòng";
            // 
            // btn_ThongKeTheoMatDoSuDung
            // 
            this.btn_ThongKeTheoMatDoSuDung.BackgroundImage = global::GUI.Properties.Resources.report1;
            this.btn_ThongKeTheoMatDoSuDung.FlatAppearance.BorderSize = 0;
            this.btn_ThongKeTheoMatDoSuDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThongKeTheoMatDoSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKeTheoMatDoSuDung.Location = new System.Drawing.Point(737, 207);
            this.btn_ThongKeTheoMatDoSuDung.Name = "btn_ThongKeTheoMatDoSuDung";
            this.btn_ThongKeTheoMatDoSuDung.Size = new System.Drawing.Size(460, 452);
            this.btn_ThongKeTheoMatDoSuDung.TabIndex = 4;
            this.btn_ThongKeTheoMatDoSuDung.UseVisualStyleBackColor = true;
            this.btn_ThongKeTheoMatDoSuDung.Click += new System.EventHandler(this.btn_ThongKeTheoMatDoSuDung_Click);
            // 
            // fStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1306, 788);
            this.Controls.Add(this.btn_ThongKeTheoMatDoSuDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ThongKeTheoDoanhThu);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Button btn_QuayLai;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_ThongKeTheoDoanhThu;
        private Label label2;
        private Label label3;
        private Button btn_ThongKeTheoMatDoSuDung;
    }
}