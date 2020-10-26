namespace QuanLyThuVien
{
    partial class CuonSachFr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagvCuonSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐầuSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCuốnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNXBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhTrạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMaCuonSach = new System.Windows.Forms.TextBox();
            this.txtMaDauSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCuonSach)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagvCuonSach
            // 
            this.datagvCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvCuonSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagvCuonSach.GridColor = System.Drawing.Color.White;
            this.datagvCuonSach.Location = new System.Drawing.Point(12, 115);
            this.datagvCuonSach.Name = "datagvCuonSach";
            this.datagvCuonSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagvCuonSach.Size = new System.Drawing.Size(460, 240);
            this.datagvCuonSach.TabIndex = 40;
            this.datagvCuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvTacGia_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã cuốn sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Đầu sách";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(274, 76);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 32;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(397, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(194, 361);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Còn ",
            "Đã cho mượn"});
            this.cbTinhTrang.Location = new System.Drawing.Point(351, 40);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(90, 21);
            this.cbTinhTrang.TabIndex = 46;
            this.cbTinhTrang.Text = "Còn ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýĐầuSáchToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýThểLoạiToolStripMenuItem,
            this.quảnLýCuốnSáchToolStripMenuItem,
            this.quảnLýNXBToolStripMenuItem,
            this.tìnhTrạngToolStripMenuItem,
            this.quảnLýThủThưToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // quảnLýĐầuSáchToolStripMenuItem
            // 
            this.quảnLýĐầuSáchToolStripMenuItem.Name = "quảnLýĐầuSáchToolStripMenuItem";
            this.quảnLýĐầuSáchToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýĐầuSáchToolStripMenuItem.Text = "Quản lý đầu sách";
            this.quảnLýĐầuSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐầuSáchToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản lý tác giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            this.quảnLýĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem_Click);
            // 
            // quảnLýThểLoạiToolStripMenuItem
            // 
            this.quảnLýThểLoạiToolStripMenuItem.Name = "quảnLýThểLoạiToolStripMenuItem";
            this.quảnLýThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýThểLoạiToolStripMenuItem.Text = "Quản lý thể loại";
            this.quảnLýThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThểLoạiToolStripMenuItem_Click);
            // 
            // quảnLýCuốnSáchToolStripMenuItem
            // 
            this.quảnLýCuốnSáchToolStripMenuItem.Name = "quảnLýCuốnSáchToolStripMenuItem";
            this.quảnLýCuốnSáchToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýCuốnSáchToolStripMenuItem.Text = "Quản lý cuốn sách";
            this.quảnLýCuốnSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCuốnSáchToolStripMenuItem_Click);
            // 
            // quảnLýNXBToolStripMenuItem
            // 
            this.quảnLýNXBToolStripMenuItem.Name = "quảnLýNXBToolStripMenuItem";
            this.quảnLýNXBToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýNXBToolStripMenuItem.Text = "Quản lý NXB";
            this.quảnLýNXBToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNXBToolStripMenuItem_Click);
            // 
            // tìnhTrạngToolStripMenuItem
            // 
            this.tìnhTrạngToolStripMenuItem.Name = "tìnhTrạngToolStripMenuItem";
            this.tìnhTrạngToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tìnhTrạngToolStripMenuItem.Text = "Tình trạng";
            this.tìnhTrạngToolStripMenuItem.Click += new System.EventHandler(this.tìnhTrạngToolStripMenuItem_Click);
            // 
            // quảnLýThủThưToolStripMenuItem
            // 
            this.quảnLýThủThưToolStripMenuItem.Name = "quảnLýThủThưToolStripMenuItem";
            this.quảnLýThủThưToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quảnLýThủThưToolStripMenuItem.Text = "Quản lý thủ thư";
            this.quảnLýThủThưToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThủThưToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhiếuTrảToolStripMenuItem,
            this.quảnLýPhiếuMượnToolStripMenuItem});
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            // 
            // quảnLýPhiếuTrảToolStripMenuItem
            // 
            this.quảnLýPhiếuTrảToolStripMenuItem.Name = "quảnLýPhiếuTrảToolStripMenuItem";
            this.quảnLýPhiếuTrảToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýPhiếuTrảToolStripMenuItem.Text = "Quản lý phiếu trả";
            this.quảnLýPhiếuTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhiếuTrảToolStripMenuItem_Click);
            // 
            // quảnLýPhiếuMượnToolStripMenuItem
            // 
            this.quảnLýPhiếuMượnToolStripMenuItem.Name = "quảnLýPhiếuMượnToolStripMenuItem";
            this.quảnLýPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýPhiếuMượnToolStripMenuItem.Text = "Quản lý phiếu mượn";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêMượnSáchToolStripMenuItem,
            this.thốngKêSáchToolStripMenuItem,
            this.thốngKêTácGiảToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêMượnSáchToolStripMenuItem
            // 
            this.thốngKêMượnSáchToolStripMenuItem.Name = "thốngKêMượnSáchToolStripMenuItem";
            this.thốngKêMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thốngKêMượnSáchToolStripMenuItem.Text = "Thống kê mượn sách";
            this.thốngKêMượnSáchToolStripMenuItem.Click += new System.EventHandler(this.thốngKêMượnSáchToolStripMenuItem_Click);
            // 
            // thốngKêSáchToolStripMenuItem
            // 
            this.thốngKêSáchToolStripMenuItem.Name = "thốngKêSáchToolStripMenuItem";
            this.thốngKêSáchToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thốngKêSáchToolStripMenuItem.Text = "Thống kê sách";
            this.thốngKêSáchToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSáchToolStripMenuItem_Click);
            // 
            // thốngKêTácGiảToolStripMenuItem
            // 
            this.thốngKêTácGiảToolStripMenuItem.Name = "thốngKêTácGiảToolStripMenuItem";
            this.thốngKêTácGiảToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thốngKêTácGiảToolStripMenuItem.Text = "Thống kê tác giả";
            this.thốngKêTácGiảToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTácGiảToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMaCuonSach
            // 
            this.txtMaCuonSach.Location = new System.Drawing.Point(113, 81);
            this.txtMaCuonSach.Name = "txtMaCuonSach";
            this.txtMaCuonSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaCuonSach.TabIndex = 38;
            this.txtMaCuonSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDausach_KeyPress);
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.Location = new System.Drawing.Point(113, 43);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaDauSach.TabIndex = 36;
            // 
            // CuonSachFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.datagvCuonSach);
            this.Controls.Add(this.txtMaCuonSach);
            this.Controls.Add(this.txtMaDauSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "CuonSachFr";
            this.Text = "Quản lý cuốn sách";
            this.Load += new System.EventHandler(this.CuonSachFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagvCuonSach)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvCuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐầuSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCuốnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNXBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhTrạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThủThưToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaCuonSach;
        private System.Windows.Forms.TextBox txtMaDauSach;
    }
}