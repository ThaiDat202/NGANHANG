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
    public partial class frmMoTK : Form
    {
        private String soTK = "";
        public frmMoTK()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.TaiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void frmMoTK_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoKhachHang' table. You can move, or remove it, as needed.
            this.infoKhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.infoKhachHangTableAdapter.Fill(this.NGANHANGDataSet.InfoKhachHang);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "ChiNhanh")
            {
                pnlCN.Enabled = false;
                btnItemAdd.Enabled = true;
            }

        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = TaiKhoanGridControl.Enabled = false;
            if (Program.servername == "DESKTOP-H0GEECA\\SERVER1")
                txtMACN.Text = "BENTHANH";
            else
                txtMACN.Text = "TANDINH";

            Program.myReader = Program.ExecSqlDataReader("SELECT TOP (1) SOTK FROM dbo.TaiKhoan ORDER BY SOTK DESC ");
            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                soTK = Convert.ToString(int.Parse(Program.myReader.GetSqlString(0).ToString()) + 1);
            }

            Program.myReader.Close();

            txtSoTK.Text = soTK;
            nGAYMOTKDateEdit.DateTime = DateTime.Now;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaiKhoanBindingSource.CancelEdit();
            if (btnItemAdd.Enabled == false)
            {
                btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = TaiKhoanGridControl.Enabled = true;
                btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
            }
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbxCMND.Text == "")
            {
                MessageBox.Show("Vui lòng chọn CMND khách hàng !", "", MessageBoxButtons.OK);
                cbxCMND.Focus();
                return;
            }
            if (MessageBox.Show("Bạn muốn mở tài khoản mới cho khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    string query = "EXEC SP_MoTaiKhoan '"+ txtSoTK.Text + "','" + cbxCMND.SelectedValue.ToString().Trim() + "', '"
                                                    + txtMACN.Text.ToString().Trim() + "' , '" + nGAYMOTKDateEdit.Text + "' ";
                    Program.ExecSqlNonQuery(query);
                    MessageBox.Show("Mở tài khoản mới thành công", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mở tài khoản mới. Vui lòng thử lại !\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = TaiKhoanGridControl.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
            else
            {
                NGANHANGDataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
                this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);
                // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoKhachHang' table. You can move, or remove it, as needed.
                this.infoKhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.infoKhachHangTableAdapter.Fill(this.NGANHANGDataSet.InfoKhachHang);
            }
        }

        private void frmMoTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbChiNhanh.SelectedIndexChanged -= cmbChiNhanh_SelectedIndexChanged;
        }

        private void cbxCMND_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
