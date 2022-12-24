namespace GUI
{
    partial class fRevenueStatistics
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.toppanel.Size = new System.Drawing.Size(1009, 151);
            this.toppanel.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(587, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo mật độ sử dụng phòng";
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
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(807, 588);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(131, 47);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThemPhong.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemPhong.Location = new System.Drawing.Point(91, 588);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(175, 47);
            this.btn_ThemPhong.TabIndex = 11;
            this.btn_ThemPhong.Text = "Xem thống kê";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 31);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(317, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tháng";
            // 
            // fRevenueStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 666);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThemPhong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRevenueStatistics";
            this.Text = "fRevenueStatistics";
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
        private Button btn_Thoat;
        private Button btn_ThemPhong;
        private System.Windows.Forms.TextBox textBox1;
        private Label label2;
    }
}