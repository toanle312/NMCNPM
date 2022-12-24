namespace GUI
{
    partial class fSearchRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSearchRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusRoom3 = new System.Windows.Forms.CheckBox();
            this.statusRoom2 = new System.Windows.Forms.CheckBox();
            this.statusRoom1 = new System.Windows.Forms.CheckBox();
            this.typeRoomC = new System.Windows.Forms.CheckBox();
            this.typeRoomB = new System.Windows.Forms.CheckBox();
            this.typeRoomA = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.type = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(3, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại phòng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTextBox.Location = new System.Drawing.Point(8, 14);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PlaceholderText = "Nhập mã phòng";
            this.idTextBox.Size = new System.Drawing.Size(251, 42);
            this.idTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(232)))), ((int)(((byte)(88)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(80, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 37);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Tìm kiếm";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.statusRoom3);
            this.panel2.Controls.Add(this.statusRoom2);
            this.panel2.Controls.Add(this.statusRoom1);
            this.panel2.Controls.Add(this.typeRoomC);
            this.panel2.Controls.Add(this.typeRoomB);
            this.panel2.Controls.Add(this.typeRoomA);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Location = new System.Drawing.Point(8, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 403);
            this.panel2.TabIndex = 8;
            // 
            // statusRoom3
            // 
            this.statusRoom3.AutoSize = true;
            this.statusRoom3.BackColor = System.Drawing.Color.Transparent;
            this.statusRoom3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusRoom3.Location = new System.Drawing.Point(25, 352);
            this.statusRoom3.Name = "statusRoom3";
            this.statusRoom3.Size = new System.Drawing.Size(101, 30);
            this.statusRoom3.TabIndex = 14;
            this.statusRoom3.Text = "Bảo trì";
            this.statusRoom3.UseVisualStyleBackColor = false;
            this.statusRoom3.CheckedChanged += new System.EventHandler(this.statusRoom3_CheckedChanged);
            // 
            // statusRoom2
            // 
            this.statusRoom2.AutoSize = true;
            this.statusRoom2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusRoom2.Location = new System.Drawing.Point(25, 316);
            this.statusRoom2.Name = "statusRoom2";
            this.statusRoom2.Size = new System.Drawing.Size(175, 30);
            this.statusRoom2.TabIndex = 13;
            this.statusRoom2.Text = "Đang sử dụng";
            this.statusRoom2.UseVisualStyleBackColor = true;
            this.statusRoom2.CheckedChanged += new System.EventHandler(this.statusRoom2_CheckedChanged);
            // 
            // statusRoom1
            // 
            this.statusRoom1.AutoSize = true;
            this.statusRoom1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusRoom1.Location = new System.Drawing.Point(25, 280);
            this.statusRoom1.Name = "statusRoom1";
            this.statusRoom1.Size = new System.Drawing.Size(92, 30);
            this.statusRoom1.TabIndex = 12;
            this.statusRoom1.Text = "Trống";
            this.statusRoom1.UseVisualStyleBackColor = true;
            this.statusRoom1.CheckedChanged += new System.EventHandler(this.statusRoom1_CheckedChanged);
            // 
            // typeRoomC
            // 
            this.typeRoomC.AutoSize = true;
            this.typeRoomC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeRoomC.Location = new System.Drawing.Point(25, 218);
            this.typeRoomC.Name = "typeRoomC";
            this.typeRoomC.Size = new System.Drawing.Size(51, 30);
            this.typeRoomC.TabIndex = 11;
            this.typeRoomC.Text = "C";
            this.typeRoomC.UseVisualStyleBackColor = true;
            this.typeRoomC.CheckedChanged += new System.EventHandler(this.typeRoomC_CheckedChanged);
            // 
            // typeRoomB
            // 
            this.typeRoomB.AutoSize = true;
            this.typeRoomB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeRoomB.Location = new System.Drawing.Point(25, 182);
            this.typeRoomB.Name = "typeRoomB";
            this.typeRoomB.Size = new System.Drawing.Size(49, 30);
            this.typeRoomB.TabIndex = 10;
            this.typeRoomB.Text = "B";
            this.typeRoomB.UseVisualStyleBackColor = true;
            this.typeRoomB.CheckedChanged += new System.EventHandler(this.typeRoomB_CheckedChanged);
            // 
            // typeRoomA
            // 
            this.typeRoomA.AutoSize = true;
            this.typeRoomA.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeRoomA.Location = new System.Drawing.Point(25, 146);
            this.typeRoomA.Name = "typeRoomA";
            this.typeRoomA.Size = new System.Drawing.Size(49, 30);
            this.typeRoomA.TabIndex = 9;
            this.typeRoomA.Text = "A";
            this.typeRoomA.UseVisualStyleBackColor = true;
            this.typeRoomA.CheckedChanged += new System.EventHandler(this.typeRoomA_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(832, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh sách phòng";
            // 
            // showRoom
            // 
            this.showRoom.AutoScroll = true;
            this.showRoom.BackColor = System.Drawing.Color.FloralWhite;
            this.showRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showRoom.Location = new System.Drawing.Point(281, 86);
            this.showRoom.Margin = new System.Windows.Forms.Padding(0);
            this.showRoom.Name = "showRoom";
            this.showRoom.Size = new System.Drawing.Size(790, 403);
            this.showRoom.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(788, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(8, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 160);
            this.panel1.TabIndex = 13;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.type.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(223, 106);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(146, 34);
            this.type.TabIndex = 23;
            this.type.Text = "loại phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(45, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã phòng  :";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.Location = new System.Drawing.Point(739, 106);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(134, 34);
            this.status.TabIndex = 21;
            this.status.Text = "trạng thái";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.id.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(223, 51);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(144, 34);
            this.id.TabIndex = 20;
            this.id.Text = "mã phòng";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.price.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(739, 51);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(213, 34);
            this.price.TabIndex = 19;
            this.price.Text = "tiền thuê phòng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(45, 106);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(182, 32);
            this.label.TabIndex = 18;
            this.label.Text = "Loại phòng :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(562, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(182, 32);
            this.label20.TabIndex = 17;
            this.label20.Text = "Trạng thái   :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(563, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Giá phòng  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(466, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chi tiết phòng";
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
            this.closeButton.Location = new System.Drawing.Point(907, 666);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 42);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Đóng";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fSearchRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSearchRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSearchRoom";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private Button searchButton;
        private Panel panel2;
        private Label label4;
        private FlowLayoutPanel showRoom;
        private CheckBox statusRoom3;
        private CheckBox statusRoom2;
        private CheckBox statusRoom1;
        private CheckBox typeRoomC;
        private CheckBox typeRoomB;
        private CheckBox typeRoomA;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label status;
        private Label id;
        private Label price;
        private Label label;
        private Label label20;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label type;
        private Button closeButton;
    }
}