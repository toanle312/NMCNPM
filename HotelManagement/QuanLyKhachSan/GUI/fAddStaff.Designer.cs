namespace GUI
{
    partial class fAddStaff
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
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.txbHT = new System.Windows.Forms.TextBox();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbDT = new System.Windows.Forms.TextBox();
            this.txbDC = new System.Windows.Forms.TextBox();
            this.txbMaTK = new System.Windows.Forms.TextBox();
            this.btbAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbGT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbClose
            // 
            this.ptbClose.Image = global::GUI.Properties.Resources.exit;
            this.ptbClose.Location = new System.Drawing.Point(896, 12);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(60, 60);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(389, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(394, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(394, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "CCCD/CMND : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(394, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính  : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa Chỉ : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điện Thoại : ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã TK : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(61, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 269);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.human_resources;
            this.pictureBox1.Location = new System.Drawing.Point(64, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbMaNV.Location = new System.Drawing.Point(596, 156);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(305, 31);
            this.txbMaNV.TabIndex = 3;
            // 
            // txbHT
            // 
            this.txbHT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbHT.Location = new System.Drawing.Point(596, 218);
            this.txbHT.Name = "txbHT";
            this.txbHT.Size = new System.Drawing.Size(305, 31);
            this.txbHT.TabIndex = 3;
            // 
            // txbCMND
            // 
            this.txbCMND.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbCMND.Location = new System.Drawing.Point(596, 275);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(305, 31);
            this.txbCMND.TabIndex = 3;
            // 
            // txbDT
            // 
            this.txbDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbDT.Location = new System.Drawing.Point(270, 484);
            this.txbDT.Name = "txbDT";
            this.txbDT.Size = new System.Drawing.Size(421, 31);
            this.txbDT.TabIndex = 3;
            // 
            // txbDC
            // 
            this.txbDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbDC.Location = new System.Drawing.Point(270, 419);
            this.txbDC.Name = "txbDC";
            this.txbDC.Size = new System.Drawing.Size(421, 31);
            this.txbDC.TabIndex = 3;
            // 
            // txbMaTK
            // 
            this.txbMaTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbMaTK.Location = new System.Drawing.Point(270, 543);
            this.txbMaTK.Name = "txbMaTK";
            this.txbMaTK.Size = new System.Drawing.Size(421, 31);
            this.txbMaTK.TabIndex = 3;
            // 
            // btbAdd
            // 
            this.btbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbAdd.BackColor = System.Drawing.Color.Lime;
            this.btbAdd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbAdd.Location = new System.Drawing.Point(755, 591);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(185, 50);
            this.btbAdd.TabIndex = 4;
            this.btbAdd.Text = "ADD";
            this.btbAdd.UseVisualStyleBackColor = false;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(309, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 52);
            this.label8.TabIndex = 5;
            this.label8.Text = "THÊM NHÂN VIÊN";
            // 
            // txbGT
            // 
            this.txbGT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txbGT.Location = new System.Drawing.Point(596, 333);
            this.txbGT.Name = "txbGT";
            this.txbGT.Size = new System.Drawing.Size(305, 31);
            this.txbGT.TabIndex = 3;
            // 
            // fAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(968, 663);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btbAdd);
            this.Controls.Add(this.txbDC);
            this.Controls.Add(this.txbMaTK);
            this.Controls.Add(this.txbDT);
            this.Controls.Add(this.txbGT);
            this.Controls.Add(this.txbCMND);
            this.Controls.Add(this.txbHT);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddStaff";
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptbClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txbHT;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbDT;
        private System.Windows.Forms.TextBox txbDC;
        private System.Windows.Forms.TextBox txbMaTK;
        private Button btbAdd;
        private Label label8;
        private System.Windows.Forms.TextBox txbGT;
    }
}