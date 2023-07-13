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
    public partial class frmGuiRut : Form
    {
        int vitri = 0;
        public frmGuiRut()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.GD_GOIRUTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void frmGuiRut_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "ChiNhanh")
            {
                pnlCN.Enabled = false;
                btnItemAdd.Enabled = true;
            }

            cmbLoaiGD.Items.Insert(0, "GT");
            cmbLoaiGD.Items.Insert(1, "RT");
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
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
                this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.
                this.TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TaiKhoanTableAdapter.Fill(this.NGANHANGDataSet.TaiKhoan);
            }
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GD_GOIRUTBindingSource.CancelEdit();
            if (btnItemAdd.Enabled == false)
                GD_GOIRUTBindingSource.Position = vitri;
            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = GD_GOIRUTBindingSource.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = false;
            GD_GOIRUTBindingSource.AddNew();
            txtMANV.Text = Program.username;
            
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GD_GOIRUTBindingSource.EndEdit();
                GD_GOIRUTBindingSource.ResetCurrentItem();

                if (cmbSoTK.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn số tài khoản !", "", MessageBoxButtons.OK);
                    cmbSoTK.Focus();
                    return;
                }

                if (cmbLoaiGD.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn loại giao dịch !", "", MessageBoxButtons.OK);
                    cmbLoaiGD.Focus();
                    return;
                }

                if (Convert.ToInt32(txtSoTien.EditValue) < 100000 || txtSoTien.EditValue == null)
                {
                    MessageBox.Show("Số tiền giao dịch tối thiểu phải là 100.000đ !", "", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }

                string query = "EXEC SP_GDGoiRut '"
                                + cmbSoTK.SelectedValue.ToString().Trim() + "', '"
                                + cmbLoaiGD.SelectedItem.ToString().Trim() + "', "
                                + txtSoTien.EditValue.ToString().Trim() + ", '"
                                + txtMANV.Text.ToString().Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(query);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == -1)
                {
                    MessageBox.Show("Số tài khoản không tồn tại.\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTK.Focus();
                    return;
                }
                else if (check == 1)
                {
                    MessageBox.Show("Thực hiện giao dịch thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else if (check == 0)
                {
                    MessageBox.Show("Thực hiện giao dịch thất bại.\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Số dư ko đủ để thực hiện rút tiền.", "Thông báo", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                GD_GOIRUTBindingSource.RemoveCurrent();
                MessageBox.Show("Lỗi thực hiện giao dịch.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void frmGuiRut_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbChiNhanh.SelectedIndexChanged -= cmbChiNhanh_SelectedIndexChanged;
        }
    }
    
}
