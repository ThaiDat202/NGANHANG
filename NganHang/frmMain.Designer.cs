namespace NganHang
{
    partial class frmChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuiRut = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLietKeTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLietKeKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTK = new DevExpress.XtraBars.BarButtonItem();
            this.rbHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbKH = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(44, 46, 44, 46);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnQLNV,
            this.btnQLKH,
            this.btnGuiRut,
            this.btnChuyenTien,
            this.btnLietKeTK,
            this.btnLietKeKH,
            this.btnQLTK});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 481;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHome,
            this.rbNV,
            this.rbKH,
            this.rbTK});
            this.ribbon.Size = new System.Drawing.Size(884, 193);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 5;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Caption = "Quản lý nhân viên";
            this.btnQLNV.Id = 6;
            this.btnQLNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.ImageOptions.Image")));
            this.btnQLNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNV.ImageOptions.LargeImage")));
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNV_ItemClick);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Caption = "Quản lý khách hàng";
            this.btnQLKH.Id = 7;
            this.btnQLKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKH.ImageOptions.Image")));
            this.btnQLKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLKH.ImageOptions.LargeImage")));
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLKH_ItemClick);
            // 
            // btnGuiRut
            // 
            this.btnGuiRut.Caption = "Thực hiện gửi rút";
            this.btnGuiRut.Id = 9;
            this.btnGuiRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiRut.ImageOptions.Image")));
            this.btnGuiRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuiRut.ImageOptions.LargeImage")));
            this.btnGuiRut.Name = "btnGuiRut";
            this.btnGuiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuiRut_ItemClick);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Caption = "Thực hiện chuyển tiền";
            this.btnChuyenTien.Id = 10;
            this.btnChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenTien.ImageOptions.Image")));
            this.btnChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenTien.ImageOptions.LargeImage")));
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenTien_ItemClick);
            // 
            // btnLietKeTK
            // 
            this.btnLietKeTK.Caption = "Liệt kê tài khoản";
            this.btnLietKeTK.Id = 12;
            this.btnLietKeTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLietKeTK.ImageOptions.Image")));
            this.btnLietKeTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLietKeTK.ImageOptions.LargeImage")));
            this.btnLietKeTK.Name = "btnLietKeTK";
            this.btnLietKeTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLietKeTK_ItemClick);
            // 
            // btnLietKeKH
            // 
            this.btnLietKeKH.Caption = "Liệt kê khách hàng";
            this.btnLietKeKH.Id = 13;
            this.btnLietKeKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLietKeKH.ImageOptions.Image")));
            this.btnLietKeKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLietKeKH.ImageOptions.LargeImage")));
            this.btnLietKeKH.Name = "btnLietKeKH";
            this.btnLietKeKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLietKeKH_ItemClick);
            // 
            // btnQLTK
            // 
            this.btnQLTK.Caption = "Quản lý tài khoản";
            this.btnQLTK.Id = 14;
            this.btnQLTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTK.ImageOptions.Image")));
            this.btnQLTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLTK.ImageOptions.LargeImage")));
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTK_ItemClick_1);
            // 
            // rbHome
            // 
            this.rbHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbHome.Name = "rbHome";
            this.rbHome.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbNV
            // 
            this.rbNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbNV.Name = "rbNV";
            this.rbNV.Text = "Nhân viên";
            this.rbNV.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLNV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbKH
            // 
            this.rbKH.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbKH.Name = "rbKH";
            this.rbKH.Text = "Khách hàng";
            this.rbKH.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLKH);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGuiRut);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChuyenTien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbTK
            // 
            this.rbTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbTK.Name = "rbTK";
            this.rbTK.Text = "Thống kê";
            this.rbTK.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLietKeTK);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLietKeKH);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(52, 20);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChinh";
            this.Ribbon = this.ribbon;
            this.Text = "NGÂN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnQLNV;
        private DevExpress.XtraBars.BarButtonItem btnQLKH;
        private DevExpress.XtraBars.BarButtonItem btnGuiRut;
        private DevExpress.XtraBars.BarButtonItem btnChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnLietKeTK;
        private DevExpress.XtraBars.BarButtonItem btnLietKeKH;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbNV;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbKH;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbTK;
        private DevExpress.XtraBars.BarButtonItem btnQLTK;
    }
}

