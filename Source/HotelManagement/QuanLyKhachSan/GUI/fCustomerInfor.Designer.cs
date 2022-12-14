namespace GUI
{
    partial class fCustomerInfor
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
            this.label1 = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbHT = new System.Windows.Forms.TextBox();
            this.txbQT = new System.Windows.Forms.TextBox();
            this.txbDC = new System.Windows.Forms.TextBox();
            this.txbDT = new System.Windows.Forms.TextBox();
            this.btbDelete = new System.Windows.Forms.Button();
            this.btbUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.Image = global::GUI.Properties.Resources.exit;
            this.ptbClose.Location = new System.Drawing.Point(583, 12);
            this.ptbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(34, 40);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "CCCD/CMND : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quốc Tịch : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa Chỉ : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Điện Thoại : ";
            // 
            // txbCMND
            // 
            this.txbCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbCMND.Location = new System.Drawing.Point(229, 74);
            this.txbCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(306, 27);
            this.txbCMND.TabIndex = 4;
            // 
            // txbHT
            // 
            this.txbHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbHT.Location = new System.Drawing.Point(229, 122);
            this.txbHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbHT.Name = "txbHT";
            this.txbHT.Size = new System.Drawing.Size(306, 27);
            this.txbHT.TabIndex = 4;
            // 
            // txbQT
            // 
            this.txbQT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbQT.Location = new System.Drawing.Point(229, 170);
            this.txbQT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbQT.Name = "txbQT";
            this.txbQT.Size = new System.Drawing.Size(306, 27);
            this.txbQT.TabIndex = 4;
            // 
            // txbDC
            // 
            this.txbDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbDC.Location = new System.Drawing.Point(229, 212);
            this.txbDC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDC.Name = "txbDC";
            this.txbDC.Size = new System.Drawing.Size(306, 27);
            this.txbDC.TabIndex = 4;
            // 
            // txbDT
            // 
            this.txbDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbDT.Location = new System.Drawing.Point(229, 258);
            this.txbDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDT.Name = "txbDT";
            this.txbDT.Size = new System.Drawing.Size(306, 27);
            this.txbDT.TabIndex = 4;
            // 
            // btbDelete
            // 
            this.btbDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btbDelete.BackColor = System.Drawing.Color.Red;
            this.btbDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbDelete.Location = new System.Drawing.Point(334, 336);
            this.btbDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(115, 46);
            this.btbDelete.TabIndex = 5;
            this.btbDelete.Text = "Xóa";
            this.btbDelete.UseVisualStyleBackColor = false;
            this.btbDelete.Click += new System.EventHandler(this.btbDelete_Click);
            // 
            // btbUpdate
            // 
            this.btbUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btbUpdate.BackColor = System.Drawing.Color.Lime;
            this.btbUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbUpdate.Location = new System.Drawing.Point(178, 336);
            this.btbUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbUpdate.Name = "btbUpdate";
            this.btbUpdate.Size = new System.Drawing.Size(115, 46);
            this.btbUpdate.TabIndex = 5;
            this.btbUpdate.Text = "Cập nhật";
            this.btbUpdate.UseVisualStyleBackColor = false;
            this.btbUpdate.Click += new System.EventHandler(this.btbUpdate_Click);
            // 
            // fCustomerInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(627, 410);
            this.Controls.Add(this.btbUpdate);
            this.Controls.Add(this.btbDelete);
            this.Controls.Add(this.txbDT);
            this.Controls.Add(this.txbDC);
            this.Controls.Add(this.txbQT);
            this.Controls.Add(this.txbHT);
            this.Controls.Add(this.txbCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fCustomerInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCustomerInfor";
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox ptbClose;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbHT;
        private System.Windows.Forms.TextBox txbQT;
        private System.Windows.Forms.TextBox txbDC;
        private System.Windows.Forms.TextBox txbDT;
        private Button btbDelete;
        private Button btbUpdate;
    }
}