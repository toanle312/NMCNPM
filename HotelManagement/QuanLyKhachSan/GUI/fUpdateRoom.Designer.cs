namespace GUI
{
    partial class fUpdateRoom
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_CapNhatPhong = new System.Windows.Forms.Button();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapNhatPhong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(324, 383);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(131, 47);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_CapNhatPhong
            // 
            this.btn_CapNhatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_CapNhatPhong.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CapNhatPhong.Location = new System.Drawing.Point(40, 383);
            this.btn_CapNhatPhong.Name = "btn_CapNhatPhong";
            this.btn_CapNhatPhong.Size = new System.Drawing.Size(131, 47);
            this.btn_CapNhatPhong.TabIndex = 11;
            this.btn_CapNhatPhong.Text = "Cập nhật";
            this.btn_CapNhatPhong.UseVisualStyleBackColor = false;
            this.btn_CapNhatPhong.Click += new System.EventHandler(this.btn_CapNhatPhong_Click);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(216, 283);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(211, 31);
            this.txtLoaiPhong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại phòng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(216, 181);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(211, 31);
            this.txtTinhTrang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tình trạng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(216, 86);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(211, 31);
            this.txtMaPhong.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phòng";
            // 
            // lblCapNhatPhong
            // 
            this.lblCapNhatPhong.AutoSize = true;
            this.lblCapNhatPhong.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapNhatPhong.Location = new System.Drawing.Point(111, 22);
            this.lblCapNhatPhong.Name = "lblCapNhatPhong";
            this.lblCapNhatPhong.Size = new System.Drawing.Size(257, 37);
            this.lblCapNhatPhong.TabIndex = 6;
            this.lblCapNhatPhong.Text = "Cập nhật phòng";
            // 
            // fUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(481, 467);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_CapNhatPhong);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCapNhatPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fUpdateRoom";
            this.Text = "UpdateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Thoat;
        private Button btn_CapNhatPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private Label label3;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private Label label2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private Label label1;
        private Label lblCapNhatPhong;
    }
}