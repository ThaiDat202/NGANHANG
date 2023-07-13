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


namespace NganHang
{
    public partial class frmTKTK : Form
    {
        public frmTKTK()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (deFrom.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian bắt đầu !", "", MessageBoxButtons.OK);
                deFrom.Focus();
                return;
            }
            if (deTo.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc !", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            string from = ((DateTime)deFrom.EditValue).ToString("yyyyMMdd");
            string to = ((DateTime)deTo.EditValue).AddDays(1).ToString("yyyyMMdd");
            XR_LietKeTaiKhoan rp = new XR_LietKeTaiKhoan(from, to, Convert.ToInt32(cbAll.Checked));
            if (cbAll.Checked == false)
                rp.lblTieuDe.Text = "DANH SÁCH CÁC TÀI KHOẢN MỞ TRONG KHOẢNG THỜI GIAN TỪ " + deFrom.Text.ToString().Trim() + " ĐẾN " + deTo.Text.ToString().Trim() + " CỦA " + cbxChiNhanh.Text.ToString().Trim().ToUpper();
            else
                rp.lblTieuDe.Text = "DANH SÁCH CÁC TÀI KHOẢN MỞ TRONG KHOẢNG THỜI GIAN TỪ " + deFrom.Text.ToString().Trim() + " ĐẾN " + deTo.Text.ToString().Trim() + " CỦA TẤT CẢ CHI NHÁNH";
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTKTK_Load(object sender, EventArgs e)
        {
            cbxChiNhanh.DataSource = Program.bds_dspm;
            cbxChiNhanh.DisplayMember = "TENCN";
            cbxChiNhanh.ValueMember = "TENSERVER";
            cbxChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "ChiNhanh")
            {
                cbAll.Enabled = pnlCN.Enabled = false;
            }

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

        private void frmTKTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbxChiNhanh.SelectedIndexChanged -= cbxChiNhanh_SelectedIndexChanged;
        }
    }
}
