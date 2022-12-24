namespace GUI
{
    partial class fAddCustomer
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
            this.lbMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCMND = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textDC = new System.Windows.Forms.TextBox();
            this.textQT = new System.Windows.Forms.TextBox();
            this.textDT = new System.Windows.Forms.TextBox();
            this.btbAdd = new System.Windows.Forms.Button();
            this.ptxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMode
            // 
            this.lbMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMode.Location = new System.Drawing.Point(215, -33);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(380, 102);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "\r\nADD CUSTOMER";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CCCD/CMND : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quốc Tịch : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điện Thoại : ";
            // 
            // textCMND
            // 
            this.textCMND.Location = new System.Drawing.Point(314, 99);
            this.textCMND.Name = "textCMND";
            this.textCMND.Size = new System.Drawing.Size(385, 31);
            this.textCMND.TabIndex = 2;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(314, 149);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(385, 31);
            this.textHoTen.TabIndex = 2;
            // 
            // textDC
            // 
            this.textDC.Location = new System.Drawing.Point(314, 251);
            this.textDC.Name = "textDC";
            this.textDC.Size = new System.Drawing.Size(385, 31);
            this.textDC.TabIndex = 2;
            // 
            // textQT
            // 
            this.textQT.Location = new System.Drawing.Point(314, 200);
            this.textQT.Name = "textQT";
            this.textQT.Size = new System.Drawing.Size(385, 31);
            this.textQT.TabIndex = 2;
            // 
            // textDT
            // 
            this.textDT.Location = new System.Drawing.Point(314, 304);
            this.textDT.Name = "textDT";
            this.textDT.Size = new System.Drawing.Size(385, 31);
            this.textDT.TabIndex = 2;
            // 
            // btbAdd
            // 
            this.btbAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btbAdd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbAdd.Location = new System.Drawing.Point(282, 369);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btbAdd.Size = new System.Drawing.Size(231, 58);
            this.btbAdd.TabIndex = 3;
            this.btbAdd.Text = "ADD\r\n";
            this.btbAdd.UseVisualStyleBackColor = false;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // ptxClose
            // 
            this.ptxClose.Image = global::GUI.Properties.Resources.exit;
            this.ptxClose.Location = new System.Drawing.Point(735, 9);
            this.ptxClose.Name = "ptxClose";
            this.ptxClose.Size = new System.Drawing.Size(50, 50);
            this.ptxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxClose.TabIndex = 4;
            this.ptxClose.TabStop = false;
            this.ptxClose.Click += new System.EventHandler(this.ptxClose_Click);
            // 
            // fAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptxClose);
            this.Controls.Add(this.btbAdd);
            this.Controls.Add(this.textQT);
            this.Controls.Add(this.textDT);
            this.Controls.Add(this.textDC);
            this.Controls.Add(this.textHoTen);
            this.Controls.Add(this.textCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ptxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.TextBox textCMND;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textDC;
        private System.Windows.Forms.TextBox textQT;
        private System.Windows.Forms.TextBox textDT;
        private Button btbAdd;
        private PictureBox ptxClose;
    }
}