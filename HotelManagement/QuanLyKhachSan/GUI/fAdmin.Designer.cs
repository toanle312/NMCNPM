namespace GUI
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
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
            this.statisticalBtn = new System.Windows.Forms.Button();
            this.manageStaffBtn = new System.Windows.Forms.Button();
            this.manageClientBtn = new System.Windows.Forms.Button();
            this.changeRegulationBtn = new System.Windows.Forms.Button();
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
            this.nameLabel.Size = new System.Drawing.Size(124, 32);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Quản Lý";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(3, 1);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(115, 32);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Quản lý";
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
            // statisticalBtn
            // 
            this.statisticalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.statisticalBtn.FlatAppearance.BorderSize = 0;
            this.statisticalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticalBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statisticalBtn.ForeColor = System.Drawing.Color.White;
            this.statisticalBtn.Image = ((System.Drawing.Image)(resources.GetObject("statisticalBtn.Image")));
            this.statisticalBtn.Location = new System.Drawing.Point(62, 70);
            this.statisticalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.statisticalBtn.Name = "statisticalBtn";
            this.statisticalBtn.Size = new System.Drawing.Size(280, 262);
            this.statisticalBtn.TabIndex = 8;
            this.statisticalBtn.Text = "Thống kê";
            this.statisticalBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.statisticalBtn.UseVisualStyleBackColor = false;
            this.statisticalBtn.Click += new System.EventHandler(this.placeRoomBtn_Click);
            // 
            // manageStaffBtn
            // 
            this.manageStaffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.manageStaffBtn.FlatAppearance.BorderSize = 0;
            this.manageStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageStaffBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageStaffBtn.ForeColor = System.Drawing.Color.White;
            this.manageStaffBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageStaffBtn.Image")));
            this.manageStaffBtn.Location = new System.Drawing.Point(62, 354);
            this.manageStaffBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageStaffBtn.Name = "manageStaffBtn";
            this.manageStaffBtn.Size = new System.Drawing.Size(280, 253);
            this.manageStaffBtn.TabIndex = 9;
            this.manageStaffBtn.Text = "Quản lý nhân viên";
            this.manageStaffBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageStaffBtn.UseVisualStyleBackColor = false;
            this.manageStaffBtn.Click += new System.EventHandler(this.searchRoomBtn_Click);
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
            this.manageClientBtn.Location = new System.Drawing.Point(368, 354);
            this.manageClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageClientBtn.Name = "manageClientBtn";
            this.manageClientBtn.Size = new System.Drawing.Size(380, 253);
            this.manageClientBtn.TabIndex = 3;
            this.manageClientBtn.Text = "Quản lý thông tin khách hàng";
            this.manageClientBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageClientBtn.UseVisualStyleBackColor = false;
            this.manageClientBtn.Click += new System.EventHandler(this.manageClientBtn_Click);
            // 
            // changeRegulationBtn
            // 
            this.changeRegulationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.changeRegulationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeRegulationBtn.FlatAppearance.BorderSize = 0;
            this.changeRegulationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeRegulationBtn.Font = new System.Drawing.Font("Arial", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeRegulationBtn.ForeColor = System.Drawing.Color.White;
            this.changeRegulationBtn.Image = ((System.Drawing.Image)(resources.GetObject("changeRegulationBtn.Image")));
            this.changeRegulationBtn.Location = new System.Drawing.Point(675, 72);
            this.changeRegulationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.changeRegulationBtn.Name = "changeRegulationBtn";
            this.changeRegulationBtn.Size = new System.Drawing.Size(325, 260);
            this.changeRegulationBtn.TabIndex = 6;
            this.changeRegulationBtn.Text = "Thay đổi quy định";
            this.changeRegulationBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.changeRegulationBtn.UseVisualStyleBackColor = false;
            this.changeRegulationBtn.Click += new System.EventHandler(this.manageServiceBtn_Click);
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
            this.manageBillBtn.Location = new System.Drawing.Point(774, 354);
            this.manageBillBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageBillBtn.Name = "manageBillBtn";
            this.manageBillBtn.Size = new System.Drawing.Size(226, 253);
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
            this.manageRoomBtn.Location = new System.Drawing.Point(368, 72);
            this.manageRoomBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageRoomBtn.Name = "manageRoomBtn";
            this.manageRoomBtn.Size = new System.Drawing.Size(281, 260);
            this.manageRoomBtn.TabIndex = 10;
            this.manageRoomBtn.Text = "Quản lý phòng";
            this.manageRoomBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manageRoomBtn.UseVisualStyleBackColor = false;
            this.manageRoomBtn.Click += new System.EventHandler(this.manageRoomBtn_Click);
            // 
            // fAdmin
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
            this.Controls.Add(this.changeRegulationBtn);
            this.Controls.Add(this.exitPTB);
            this.Controls.Add(this.showMenuPTB);
            this.Controls.Add(this.manageStaffBtn);
            this.Controls.Add(this.statisticalBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAdmin";
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
        private Button manageStaffBtn;
        private Button statisticalBtn;
        private Button manageClientBtn;
        private Button changeRegulationBtn;
        private Button manageBillBtn;
        private Button manageRoomBtn;
        private Label statusLabel;
        private Label nameLabel;
    }
}