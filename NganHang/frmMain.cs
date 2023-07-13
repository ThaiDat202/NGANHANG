using DevExpress.XtraBars;
using NganHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NganHang
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void HienThiMenu()
        {
            
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên: " + Program.mHoten.Trim('\r', '\n');//remove newlines from both sides of a string
            NHOM.Text = "Nhóm: " + Program.mGroup;

            //phân quyền
            if (Program.mGroup == "NganHang")
            {
                Program.frmChinh.rbTK.Visible = true;
            }
            else
            {
                Program.frmChinh.rbNV.Visible = Program.frmChinh.rbKH.Visible = Program.frmChinh.rbTK.Visible = true;
            }

        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        // Đăng xuất
       

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                Program.mChiNhanh = 0;
                Program.mloginDN = "";
                Program.passwordDN = "";
                this.MANV.Text = "";
                this.HOTEN.Text = "";
                this.NHOM.Text = "";
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }

                
                Program.frmChinh.rbNV.Visible = Program.frmChinh.rbKH.Visible = Program.frmChinh.rbTK.Visible = false;
                Program.frmChinh.btnDangNhap.Enabled = true;
                Program.frmChinh.btnDangXuat.Enabled = false;
            }
            


            
                
            
            

        }

        private void btnQLNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNV));
            if (frm != null) frm.Activate();
            else
            {
                frmNV f = new frmNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTK));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTK f = new frmTaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnGuiRut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGuiRut));
            if (frm != null) frm.Activate();
            else
            {
                frmGuiRut f = new frmGuiRut();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChuyenTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChuyenTien));
            if (frm != null) frm.Activate();
            else
            {
                frmChuyenTien f = new frmChuyenTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        

        private void btnLietKeTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTKTK));
            if (frm != null) frm.Activate();
            else
            {
                frmTKTK f = new frmTKTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLietKeKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTKKH));
            if (frm != null) frm.Activate();
            else
            {
                frmTKKH f = new frmTKKH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLTK_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMoTK));
            if (frm != null) frm.Activate();
            else
            {
                frmMoTK f = new frmMoTK();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}

