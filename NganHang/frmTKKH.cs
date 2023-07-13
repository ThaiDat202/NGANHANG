using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class frmTKKH : Form
    {
        public frmTKKH()
        {
            InitializeComponent();
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbxChiNhanh.SelectedValue.ToString();

            if (cbxChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới !", "", MessageBoxButtons.OK);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            XR_LietKeKhachHang1 rp = new XR_LietKeKhachHang1();
            rp.lblTieuDe.Text = "DANH SÁCH KHÁCH HÀNG CỦA " + cbxChiNhanh.Text.ToString().Trim().ToUpper();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           this.Validate();
           this.chiNhanhBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void frmTKKH_Load(object sender, EventArgs e)
        {
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "ChiNhanh")
            {
                pnlCN.Enabled = false;
            }
            this.chiNhanhTableAdapter.Fill(this.nGANHANGDataSet.ChiNhanh);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTKKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbxChiNhanh.SelectedIndexChanged -= cbxChiNhanh_SelectedIndexChanged;
        }
    }
}
