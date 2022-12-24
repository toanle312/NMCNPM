namespace GUI
{
    partial class fAddFood
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
            this.lblThemPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThemPhong
            // 
            this.lblThemPhong.AutoSize = true;
            this.lblThemPhong.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThemPhong.Location = new System.Drawing.Point(134, 30);
            this.lblThemPhong.Name = "lblThemPhong";
            this.lblThemPhong.Size = new System.Drawing.Size(206, 37);
            this.lblThemPhong.TabIndex = 0;
            this.lblThemPhong.Text = "Thêm phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(209, 99);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(211, 31);
            this.txtMaPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(209, 194);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(211, 31);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(209, 296);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(211, 31);
            this.txtLoaiPhong.TabIndex = 1;
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_ThemPhong.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemPhong.Location = new System.Drawing.Point(33, 396);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(131, 47);
            this.btn_ThemPhong.TabIndex = 2;
            this.btn_ThemPhong.Text = "Thêm phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(317, 396);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(131, 47);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // fAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(503, 503);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThemPhong);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThemPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddFood";
            this.ShowInTaskbar = false;
            this.Text = "fAddFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblThemPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private Label label3;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private Button btn_ThemPhong;
        private Button btn_Thoat;
    }
}