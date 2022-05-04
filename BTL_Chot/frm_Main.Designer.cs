namespace BTL_Chot
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_dong = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachLoaiHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_giaodichPN = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CTPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CTHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hêThôngToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.giaodich});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1180, 43);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dong});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(133, 39);
            this.hêThôngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // menu_dong
            // 
            this.menu_dong.Name = "menu_dong";
            this.menu_dong.Size = new System.Drawing.Size(224, 40);
            this.menu_dong.Text = "&Đóng";
            this.menu_dong.Click += new System.EventHandler(this.menu_dong_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NhanVien,
            this.danhSachLoaiHangToolStripMenuItem,
            this.KhachHangToolStripMenuItem,
            this.MatHangToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(114, 39);
            this.quanLyToolStripMenuItem.Text = "&Quản lý";
            // 
            // menu_NhanVien
            // 
            this.menu_NhanVien.Name = "menu_NhanVien";
            this.menu_NhanVien.Size = new System.Drawing.Size(235, 40);
            this.menu_NhanVien.Text = "&Nhân viên";
            this.menu_NhanVien.Click += new System.EventHandler(this.menu_NhanVien_Click);
            // 
            // danhSachLoaiHangToolStripMenuItem
            // 
            this.danhSachLoaiHangToolStripMenuItem.Name = "danhSachLoaiHangToolStripMenuItem";
            this.danhSachLoaiHangToolStripMenuItem.Size = new System.Drawing.Size(235, 40);
            this.danhSachLoaiHangToolStripMenuItem.Text = "&Loại hàng";
            this.danhSachLoaiHangToolStripMenuItem.Click += new System.EventHandler(this.danhSachLoaiHangToolStripMenuItem_Click);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(235, 40);
            this.KhachHangToolStripMenuItem.Text = "&Khách hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // MatHangToolStripMenuItem
            // 
            this.MatHangToolStripMenuItem.Name = "MatHangToolStripMenuItem";
            this.MatHangToolStripMenuItem.Size = new System.Drawing.Size(235, 40);
            this.MatHangToolStripMenuItem.Text = "&Mặt hàng";
            this.MatHangToolStripMenuItem.Click += new System.EventHandler(this.MatHangToolStripMenuItem_Click);
            // 
            // giaodich
            // 
            this.giaodich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_giaodichPN,
            this.menu_CTPhieuNhap,
            this.HoaDonToolStripMenuItem,
            this.CTHoaDonToolStripMenuItem});
            this.giaodich.Name = "giaodich";
            this.giaodich.Size = new System.Drawing.Size(134, 39);
            this.giaodich.Text = "&Giao dịch";
            // 
            // menu_giaodichPN
            // 
            this.menu_giaodichPN.Name = "menu_giaodichPN";
            this.menu_giaodichPN.Size = new System.Drawing.Size(313, 40);
            this.menu_giaodichPN.Text = "&Phiếu nhập";
            this.menu_giaodichPN.Click += new System.EventHandler(this.menu_giaodichPN_Click);
            // 
            // menu_CTPhieuNhap
            // 
            this.menu_CTPhieuNhap.Name = "menu_CTPhieuNhap";
            this.menu_CTPhieuNhap.Size = new System.Drawing.Size(313, 40);
            this.menu_CTPhieuNhap.Text = "&Chi tiết phiếu nhập";
            this.menu_CTPhieuNhap.Click += new System.EventHandler(this.menu_CTPhieuNhap_Click);
            // 
            // HoaDonToolStripMenuItem
            // 
            this.HoaDonToolStripMenuItem.Name = "HoaDonToolStripMenuItem";
            this.HoaDonToolStripMenuItem.Size = new System.Drawing.Size(313, 40);
            this.HoaDonToolStripMenuItem.Text = "&Hóa đơn";
            this.HoaDonToolStripMenuItem.Click += new System.EventHandler(this.HoaDonToolStripMenuItem_Click);
            // 
            // CTHoaDonToolStripMenuItem
            // 
            this.CTHoaDonToolStripMenuItem.Name = "CTHoaDonToolStripMenuItem";
            this.CTHoaDonToolStripMenuItem.Size = new System.Drawing.Size(313, 40);
            this.CTHoaDonToolStripMenuItem.Text = "&Chi tiết hóa đơn";
            this.CTHoaDonToolStripMenuItem.Click += new System.EventHandler(this.CTHoaDonToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1180, 738);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_dong;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem danhSachLoaiHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaodich;
        private System.Windows.Forms.ToolStripMenuItem menu_giaodichPN;
        private System.Windows.Forms.ToolStripMenuItem menu_CTPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem HoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CTHoaDonToolStripMenuItem;
    }
}