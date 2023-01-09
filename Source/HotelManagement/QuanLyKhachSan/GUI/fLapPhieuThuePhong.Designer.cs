namespace GUI
{
    partial class fLapPhieuThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLapPhieuThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.songuoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngoaiquoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.exitPTB = new System.Windows.Forms.PictureBox();
            this.maphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // cmnd
            // 
            this.cmnd.Location = new System.Drawing.Point(168, 173);
            this.cmnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(100, 27);
            this.cmnd.TabIndex = 2;
            // 
            // songuoi
            // 
            this.songuoi.FormattingEnabled = true;
            this.songuoi.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.songuoi.Location = new System.Drawing.Point(168, 277);
            this.songuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.songuoi.Name = "songuoi";
            this.songuoi.Size = new System.Drawing.Size(100, 28);
            this.songuoi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số người";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngoại quốc";
            // 
            // ngoaiquoc
            // 
            this.ngoaiquoc.FormattingEnabled = true;
            this.ngoaiquoc.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.ngoaiquoc.Location = new System.Drawing.Point(168, 333);
            this.ngoaiquoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ngoaiquoc.Name = "ngoaiquoc";
            this.ngoaiquoc.Size = new System.Drawing.Size(100, 28);
            this.ngoaiquoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(446, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách đặt phòng trong ngày";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.button1.Location = new System.Drawing.Point(30, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.button2.Location = new System.Drawing.Point(200, 422);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Lập phiếu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(329, 146);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 410);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "STT";
            this.columnHeader0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader0.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CMND";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số người";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngoại quốc";
            this.columnHeader3.Width = 108;
            // 
            // exitPTB
            // 
            this.exitPTB.BackColor = System.Drawing.Color.Transparent;
            this.exitPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPTB.Image = ((System.Drawing.Image)(resources.GetObject("exitPTB.Image")));
            this.exitPTB.Location = new System.Drawing.Point(856, 25);
            this.exitPTB.Name = "exitPTB";
            this.exitPTB.Size = new System.Drawing.Size(30, 30);
            this.exitPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPTB.TabIndex = 15;
            this.exitPTB.TabStop = false;
            this.exitPTB.Click += new System.EventHandler(this.exitPTB_Click);
            // 
            // maphong
            // 
            this.maphong.FormattingEnabled = true;
            this.maphong.Location = new System.Drawing.Point(168, 222);
            this.maphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(100, 28);
            this.maphong.TabIndex = 16;
            // 
            // fLapPhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(910, 610);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.exitPTB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngoaiquoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.songuoi);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fLapPhieuThuePhong";
            this.Text = "Phiếu thuê phòng";
            this.Load += new System.EventHandler(this.fLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.ComboBox songuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ngoaiquoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private PictureBox exitPTB;
        private ComboBox maphong;
    }
}