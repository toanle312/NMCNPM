namespace GUI
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            this.showMenuPTB = new System.Windows.Forms.PictureBox();
            this.exitPTB = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.avatarPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hideMenuPTB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.functionPanel = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.introduceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.placeRoomBtn = new System.Windows.Forms.Button();
            this.searchRoomBtn = new System.Windows.Forms.Button();
            this.manageClientBtn = new System.Windows.Forms.Button();
            this.makeReportBtn = new System.Windows.Forms.Button();
            this.useService = new System.Windows.Forms.Button();
            this.manageServiceBtn = new System.Windows.Forms.Button();
            this.manageBillBtn = new System.Windows.Forms.Button();
            this.manageRoomBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showMenuPTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.avatarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideMenuPTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.functionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showMenuPTB
            // 
            this.showMenuPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMenuPTB.Image = ((System.Drawing.Image)(resources.GetObject("showMenuPTB.Image")));
            this.showMenuPTB.Location = new System.Drawing.Point(12, 12);
            this.showMenuPTB.Name = "showMenuPTB";
            this.showMenuPTB.Size = new System.Drawing.Size(40, 40);
            this.showMenuPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showMenuPTB.TabIndex = 0;
            this.showMenuPTB.TabStop = false;
            this.showMenuPTB.Click += new System.EventHandler(this.showMenuPTB_Click);
            // 
            // exitPTB
            // 
            this.exitPTB.BackColor = System.Drawing.Color.Transparent;
            this.exitPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPTB.Image = ((System.Drawing.Image)(resources.GetObject("exitPTB.Image")));
            this.exitPTB.Location = new System.Drawing.Point(1020, 12);
            this.exitPTB.Name = "exitPTB";
            this.exitPTB.Size = new System.Drawing.Size(30, 30);
            this.exitPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPTB.TabIndex = 1;
            this.exitPTB.TabStop = false;
            this.exitPTB.Click += new System.EventHandler(this.exitPTB_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundImage = global::GUI.Properties.Resources.background;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.Controls.Add(this.avatarPanel);
            this.menuPanel.Controls.Add(this.functionPanel);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(379, 676);
            this.menuPanel.TabIndex = 2;
            // 
            // avatarPanel
            // 
            this.avatarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.avatarPanel.Controls.Add(this.nameLabel);
            this.avatarPanel.Controls.Add(this.statusLabel);
            this.avatarPanel.Controls.Add(this.hideMenuPTB);
            this.avatarPanel.Controls.Add(this.pictureBox1);
            this.avatarPanel.Location = new System.Drawing.Point(0, 0);
            this.avatarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.avatarPanel.Name = "avatarPanel";
            this.avatarPanel.Size = new System.Drawing.Size(379, 233);
            this.avatarPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(71, 190);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(149, 32);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nhân Viên";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(3, 1);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(149, 32);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Nhân Viên";
            // 
            // hideMenuPTB
            // 
            this.hideMenuPTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideMenuPTB.Image = global::GUI.Properties.Resources.hide;
            this.hideMenuPTB.Location = new System.Drawing.Point(336, 3);
            this.hideMenuPTB.Name = "hideMenuPTB";
            this.hideMenuPTB.Size = new System.Drawing.Size(40, 40);
            this.hideMenuPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hideMenuPTB.TabIndex = 0;
            this.hideMenuPTB.TabStop = false;
            this.hideMenuPTB.Click += new System.EventHandler(this.hideMenuPTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.Color.Transparent;
            this.functionPanel.Controls.Add(this.logOutButton);
            this.functionPanel.Controls.Add(this.introduceButton);
            this.functionPanel.Controls.Add(this.infoButton);
            this.functionPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.functionPanel.Location = new System.Drawing.Point(0, 233);
            this.functionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(379, 443);
            this.functionPanel.TabIndex = 2;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Image = global::GUI.Properties.Resources.logout__1_;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(15, 121);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(177, 34);
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "Đăng xuất";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // introduceButton
            // 
            this.introduceButton.BackColor = System.Drawing.Color.Transparent;
            this.introduceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.introduceButton.FlatAppearance.BorderSize = 0;
            this.introduceButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.introduceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.introduceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.introduceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.introduceButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introduceButton.ForeColor = System.Drawing.Color.Black;
            this.introduceButton.Image = global::GUI.Properties.Resources.introduce__1_;
            this.introduceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.introduceButton.Location = new System.Drawing.Point(12, 66);
            this.introduceButton.Margin = new System.Windows.Forms.Padding(0);
            this.introduceButton.Name = "introduceButton";
            this.introduceButton.Size = new System.Drawing.Size(178, 34);
            this.introduceButton.TabIndex = 9;
            this.introduceButton.Text = "Giới thiệu";
            this.introduceButton.UseVisualStyleBackColor = false;
            this.introduceButton.Click += new System.EventHandler(this.introduceButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoButton.ForeColor = System.Drawing.Color.Black;
            this.infoButton.Image = global::GUI.Properties.Resources.info;
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.Location = new System.Drawing.Point(15, 19);
            this.infoButton.Margin = new System.Windows.Forms.Padding(0);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(246, 34);
            this.infoButton.TabIndex = 0;
            this.infoButton.Text = "Thông tin tài khoản";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // placeRoomBtn
            // 
            this.placeRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.placeRoomBtn.FlatAppearance.BorderSize = 0;
            this.placeRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeRoomBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeRoomBtn.ForeColor = System.Drawing.Color.White;
            this.placeRoomBtn.Image = global::GUI.Properties.Resources.bookRoom;
            this.placeRoomBtn.Location = new System.Drawing.Point(62, 70);
            this.placeRoomBtn.Margin = new System.Windows.Forms.Padding(0);
            this.placeRoomBtn.Name = "placeRoomBtn";
            this.placeRoomBtn.Size = new System.Drawing.Size(312, 262);
            this.placeRoomBtn.TabIndex = 8;
            this.placeRoomBtn.Text = "Lập phiếu thuê phòng";
            this.placeRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.placeRoomBtn.UseVisualStyleBackColor = false;
            this.placeRoomBtn.Click += new System.EventHandler(this.placeRoomBtn_Click);
            // 
            // searchRoomBtn
            // 
            this.searchRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.searchRoomBtn.FlatAppearance.BorderSize = 0;
            this.searchRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRoomBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchRoomBtn.ForeColor = System.Drawing.Color.White;
            this.searchRoomBtn.Image = global::GUI.Properties.Resources.searchRoom;
            this.searchRoomBtn.Location = new System.Drawing.Point(62, 354);
            this.searchRoomBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchRoomBtn.Name = "searchRoomBtn";
            this.searchRoomBtn.Size = new System.Drawing.Size(312, 253);
            this.searchRoomBtn.TabIndex = 9;
            this.searchRoomBtn.Text = "Tra cứu phòng";
            this.searchRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.searchRoomBtn.UseVisualStyleBackColor = false;
            this.searchRoomBtn.Click += new System.EventHandler(this.searchRoomBtn_Click);
            // 
            // manageClientBtn
            // 
            this.manageClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.manageClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageClientBtn.FlatAppearance.BorderSize = 0;
            this.manageClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageClientBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageClientBtn.ForeColor = System.Drawing.Color.White;
            this.manageClientBtn.Image = global::GUI.Properties.Resources.manageClient;
            this.manageClientBtn.Location = new System.Drawing.Point(394, 428);
            this.manageClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageClientBtn.Name = "manageClientBtn";
            this.manageClientBtn.Size = new System.Drawing.Size(614, 179);
            this.manageClientBtn.TabIndex = 3;
            this.manageClientBtn.Text = "Quản lý thông tin khách hàng";
            this.manageClientBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageClientBtn.UseVisualStyleBackColor = false;
            this.manageClientBtn.Click += new System.EventHandler(this.manageClientBtn_Click);
            // 
            // makeReportBtn
            // 
            this.makeReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.makeReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeReportBtn.FlatAppearance.BorderSize = 0;
            this.makeReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeReportBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.makeReportBtn.ForeColor = System.Drawing.Color.White;
            this.makeReportBtn.Image = global::GUI.Properties.Resources.makeReport;
            this.makeReportBtn.Location = new System.Drawing.Point(394, 248);
            this.makeReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.makeReportBtn.Name = "makeReportBtn";
            this.makeReportBtn.Size = new System.Drawing.Size(170, 166);
            this.makeReportBtn.TabIndex = 4;
            this.makeReportBtn.Text = "Lập báo cáo";
            this.makeReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.makeReportBtn.UseVisualStyleBackColor = false;
            this.makeReportBtn.Click += new System.EventHandler(this.makeReportBtn_Click);
            // 
            // useService
            // 
            this.useService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.useService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useService.Enabled = false;
            this.useService.FlatAppearance.BorderSize = 0;
            this.useService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useService.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.useService.ForeColor = System.Drawing.Color.White;
            this.useService.Location = new System.Drawing.Point(394, 70);
            this.useService.Margin = new System.Windows.Forms.Padding(0);
            this.useService.Name = "useService";
            this.useService.Size = new System.Drawing.Size(170, 161);
            this.useService.TabIndex = 5;
            this.useService.Text = "Sử dụng dịch vụ";
            this.useService.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.useService.UseVisualStyleBackColor = false;
            this.useService.Click += new System.EventHandler(this.makeBillBtn_Click);
            // 
            // manageServiceBtn
            // 
            this.manageServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.manageServiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageServiceBtn.FlatAppearance.BorderSize = 0;
            this.manageServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageServiceBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageServiceBtn.ForeColor = System.Drawing.Color.White;
            this.manageServiceBtn.Image = global::GUI.Properties.Resources.manageService;
            this.manageServiceBtn.Location = new System.Drawing.Point(584, 248);
            this.manageServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageServiceBtn.Name = "manageServiceBtn";
            this.manageServiceBtn.Size = new System.Drawing.Size(229, 166);
            this.manageServiceBtn.TabIndex = 6;
            this.manageServiceBtn.Text = "Quản lý dịch vụ";
            this.manageServiceBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageServiceBtn.UseVisualStyleBackColor = false;
            this.manageServiceBtn.Click += new System.EventHandler(this.manageServiceBtn_Click);
            // 
            // manageBillBtn
            // 
            this.manageBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.manageBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBillBtn.FlatAppearance.BorderSize = 0;
            this.manageBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBillBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageBillBtn.ForeColor = System.Drawing.Color.White;
            this.manageBillBtn.Image = global::GUI.Properties.Resources.manageBill;
            this.manageBillBtn.Location = new System.Drawing.Point(584, 72);
            this.manageBillBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageBillBtn.Name = "manageBillBtn";
            this.manageBillBtn.Size = new System.Drawing.Size(229, 161);
            this.manageBillBtn.TabIndex = 7;
            this.manageBillBtn.Text = "Quản lý hóa đơn";
            this.manageBillBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageBillBtn.UseVisualStyleBackColor = false;
            this.manageBillBtn.Click += new System.EventHandler(this.manageBillBtn_Click);
            // 
            // manageRoomBtn
            // 
            this.manageRoomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.manageRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageRoomBtn.FlatAppearance.BorderSize = 0;
            this.manageRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageRoomBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageRoomBtn.ForeColor = System.Drawing.Color.White;
            this.manageRoomBtn.Image = global::GUI.Properties.Resources.manageRoom;
            this.manageRoomBtn.Location = new System.Drawing.Point(831, 70);
            this.manageRoomBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageRoomBtn.Name = "manageRoomBtn";
            this.manageRoomBtn.Size = new System.Drawing.Size(177, 344);
            this.manageRoomBtn.TabIndex = 10;
            this.manageRoomBtn.Text = "Quản lý phòng";
            this.manageRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageRoomBtn.UseVisualStyleBackColor = false;
            this.manageRoomBtn.Click += new System.EventHandler(this.manageRoomBtn_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.manageClientBtn);
            this.Controls.Add(this.manageRoomBtn);
            this.Controls.Add(this.manageBillBtn);
            this.Controls.Add(this.manageServiceBtn);
            this.Controls.Add(this.useService);
            this.Controls.Add(this.makeReportBtn);
            this.Controls.Add(this.exitPTB);
            this.Controls.Add(this.showMenuPTB);
            this.Controls.Add(this.searchRoomBtn);
            this.Controls.Add(this.placeRoomBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStaff";
            ((System.ComponentModel.ISupportInitialize)(this.showMenuPTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPTB)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.avatarPanel.ResumeLayout(false);
            this.avatarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideMenuPTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.functionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox showMenuPTB;
        private PictureBox exitPTB;
        private FlowLayoutPanel menuPanel;
        private Panel avatarPanel;
        private PictureBox hideMenuPTB;
        private PictureBox pictureBox1;
        private Panel functionPanel;
        private Button infoButton;
        private Button logOutButton;
        private Button introduceButton;
        private Button searchRoomBtn;
        private Button placeRoomBtn;
        private Button manageClientBtn;
        private Button makeReportBtn;
        private Button useService;
        private Button manageServiceBtn;
        private Button manageBillBtn;
        private Button manageRoomBtn;
        private Label statusLabel;
        private Label nameLabel;
    }
}