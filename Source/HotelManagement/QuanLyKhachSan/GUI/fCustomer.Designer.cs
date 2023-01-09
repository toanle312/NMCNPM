namespace GUI
{
    partial class fCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.lsvCustomer = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.ptb_icon = new System.Windows.Forms.PictureBox();
            this.ptb_Add = new System.Windows.Forms.PictureBox();
            this.lAdd = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(403, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // lsvCustomer
            // 
            this.lsvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvCustomer.GridLines = true;
            this.lsvCustomer.Location = new System.Drawing.Point(97, 253);
            this.lsvCustomer.Name = "lsvCustomer";
            this.lsvCustomer.Size = new System.Drawing.Size(1099, 325);
            this.lsvCustomer.TabIndex = 3;
            this.lsvCustomer.UseCompatibleStateImageBehavior = false;
            this.lsvCustomer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CMND";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ Tên ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quốc Tịch";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điện Thoại";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 200;
            // 
            // ptb_icon
            // 
            this.ptb_icon.Image = global::GUI.Properties.Resources.manageClient;
            this.ptb_icon.Location = new System.Drawing.Point(46, 12);
            this.ptb_icon.Name = "ptb_icon";
            this.ptb_icon.Size = new System.Drawing.Size(70, 70);
            this.ptb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_icon.TabIndex = 4;
            this.ptb_icon.TabStop = false;
            // 
            // ptb_Add
            // 
            this.ptb_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptb_Add.Image = global::GUI.Properties.Resources.Picture3;
            this.ptb_Add.Location = new System.Drawing.Point(482, 603);
            this.ptb_Add.Name = "ptb_Add";
            this.ptb_Add.Size = new System.Drawing.Size(119, 107);
            this.ptb_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Add.TabIndex = 5;
            this.ptb_Add.TabStop = false;
            this.ptb_Add.Click += new System.EventHandler(this.ptb_Add_Click);
            // 
            // lAdd
            // 
            this.lAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lAdd.AutoSize = true;
            this.lAdd.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lAdd.Location = new System.Drawing.Point(607, 635);
            this.lAdd.Name = "lAdd";
            this.lAdd.Size = new System.Drawing.Size(333, 43);
            this.lAdd.TabIndex = 7;
            this.lAdd.Text = "Thêm Khách Hàng";
            this.lAdd.Click += new System.EventHandler(this.lAdd_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(97, 193);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(274, 31);
            this.txbSearch.TabIndex = 8;
            // 
            // ptbSearch
            // 
            this.ptbSearch.BackColor = System.Drawing.Color.Lime;
            this.ptbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbSearch.Image = global::GUI.Properties.Resources.search;
            this.ptbSearch.Location = new System.Drawing.Point(379, 178);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(54, 53);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSearch.TabIndex = 9;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.Image = global::GUI.Properties.Resources.exit;
            this.ptbClose.Location = new System.Drawing.Point(1238, 12);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(50, 50);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 10;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lAdd);
            this.Controls.Add(this.ptb_Add);
            this.Controls.Add(this.ptb_icon);
            this.Controls.Add(this.lsvCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView lsvCustomer;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private PictureBox ptb_icon;
        private PictureBox ptb_Add;
        private Label lAdd;
        private System.Windows.Forms.TextBox txbSearch;
        private PictureBox ptbSearch;
        private ColumnHeader columnHeader6;
        public ColumnHeader columnHeader2;
        private PictureBox ptbClose;
    }
}