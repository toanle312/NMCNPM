namespace GUI
{
    partial class fRoomManagement
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
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDangSuDung = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.toppanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1062, 121);
            this.toppanel.TabIndex = 0;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QuayLai.Image = global::GUI.Properties.Resources.return4;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(886, 46);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(167, 46);
            this.btn_QuayLai.TabIndex = 1;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.manageRoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flpLeft
            // 
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Location = new System.Drawing.Point(0, 121);
            this.flpLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(546, 554);
            this.flpLeft.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(562, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 16);
            this.panel1.TabIndex = 2;
            // 
            // lblDangSuDung
            // 
            this.lblDangSuDung.AutoSize = true;
            this.lblDangSuDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDangSuDung.Location = new System.Drawing.Point(592, 130);
            this.lblDangSuDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDangSuDung.Name = "lblDangSuDung";
            this.lblDangSuDung.Size = new System.Drawing.Size(144, 24);
            this.lblDangSuDung.TabIndex = 3;
            this.lblDangSuDung.Text = "Đang sử dụng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(750, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 16);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(780, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trống";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(876, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 16);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(911, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bảo trì";
            // 
            // btn_Them
            // 
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Image = global::GUI.Properties.Resources.plus1;
            this.btn_Them.Location = new System.Drawing.Point(750, 229);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 59);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Image = global::GUI.Properties.Resources.pencil1;
            this.btn_CapNhat.Location = new System.Drawing.Point(750, 455);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(90, 49);
            this.btn_CapNhat.TabIndex = 4;
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(738, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thêm phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(730, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cập nhật phòng";
            // 
            // fRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1062, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDangSuDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpLeft);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fRoomManagement";
            this.Text = "fRoomManagement";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel toppanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_QuayLai;
        private FlowLayoutPanel flpLeft;
        private Panel panel1;
        private Label lblDangSuDung;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Button btn_Them;
        private Button btn_CapNhat;
        private Label label4;
        private Label label5;
    }
}