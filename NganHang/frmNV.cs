using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmNV : Form
    {
        int vitri = 0;
        string flag = "";
        public frmNV()
        {
            InitializeComponent();
        }

       
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.TableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'NGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'NGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            cmbPhai.Items.Insert(0, "Nam");
            cmbPhai.Items.Insert(1, "Nữ");

            if (Program.mGroup == "ChiNhanh")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemChuyenNV.Enabled  = true;
                pnlCN.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = pnlChuyenCN.Enabled = pnlDetail.Enabled = false;
            }
            else if (Program.mGroup == "NganHang")
            {
                btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemSave.Enabled = btnItemChuyenNV.Enabled = btnItemUndo.Enabled = btnMove.Enabled = pnlDetail.Enabled = false;
            }

            if (bdsNV.Count == 0)
                btnItemDelete.Enabled = false;
        }

        private void trangThaiXoaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

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
                
                // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_GOIRUTTableAdapter.Fill(this.NGANHANGDataSet.GD_GOIRUT);
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
                this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
            }
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = cbTTX.Enabled = gctNV.Enabled = btnItemChuyenNV.Enabled = false;
            bdsNV.AddNew();
            txtMACN.Text = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cbTTX.Checked = false;
            //gctNV.Enabled = false;
            txtMANV.Focus();
            flag = "add";
            cmbPhai.SelectedIndex = 0;
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnItemAdd.Enabled == false)
                bdsNV.Position = vitri;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = cbTTX.Enabled = btnItemChuyenNV.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = pnlChuyenCN.Enabled = false;
        }

        private void btnItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemChuyenNV.Enabled = false;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = true;
            flag = "edit";
            
        }

        private void btnItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = "";

            if (bdsGDGuiRut.Count > 0)
            {
                MessageBox.Show("Nhân viên bạn muốn xóa đã thực hiện giao dịch gửi rút, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (bdsGDChuyenTien.Count > 0)
            {
                MessageBox.Show("Nhân viên bạn muốn xóa đã thực hiện giao dịch chuyển tiền, nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có mã " + txtMANV.Text, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                    bdsNV.RemoveCurrent();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnItemDelete.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống !", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.\nHãy chắc chắn sdt có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }

            if (cmbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính !", "", MessageBoxButtons.OK);
                cmbPhai.Focus();
                return;
            }

            if (flag == "add")
            {
                string queryCheckMANV = "EXEC SP_CheckMANV '" + txtMANV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(queryCheckMANV);
                //if (Program.myReader == null)
                //    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 1)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh hiện tại !", "", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Mã nhân viên này đang tồn tại ở phân mảnh khác !", "", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }

                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    bdsNV.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (flag == "edit")
            {
                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.NGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    bdsNV.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemChuyenNV.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void btnItemChuyenNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            string queryGetCNChuyen = "EXEC SP_GetCNChuyen '" + txtMACN.Text.Trim() + "'";
            DataTable dt = Program.ExecSqlDataTable(queryGetCNChuyen);
            pnlChuyenCN.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemSave.Enabled = btnItemReload.Enabled = gctNV.Enabled = btnItemChuyenNV.Enabled = false;
            cmbMoveCN.DataSource = dt;
            cmbMoveCN.DisplayMember = "TENCN";
            cmbMoveCN.ValueMember = "MACN";
            cmbMoveCN.SelectedIndex = 0;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string manv = "";
            manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            if (manv.Equals(Program.username))
            {
                MessageBox.Show("Không được chuyển bản thân sang chi nhánh khác!", "Xác nhận", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("Bạn muốn chuyển nhân viên có mã " + txtMANV.Text.Trim()
                                + " từ " + txtMACN.Text.Trim()
                                + " sang " + cmbMoveCN.SelectedValue.ToString().Trim(), "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    string queryChuyenCN = "EXEC SP_ChuyenCN '" + txtMANV.Text.Trim()
                                                                + "', '" + cmbMoveCN.SelectedValue.ToString().Trim() + "'";
                    Program.myReader = Program.ExecSqlDataReader(queryChuyenCN);
                    if (Program.myReader == null)
                        return;
                    Program.myReader.Read();
                    int check = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (check == 1)
                    {
                        MessageBox.Show("Chuyển nhân viên thành công", "", MessageBoxButtons.OK);
                        this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                        bdsNV.Position = bdsNV.Find("MANV", manv);
                    }
                    else
                    {
                        MessageBox.Show("Chuyển nhân viên thất bại", "", MessageBoxButtons.OK);
                        this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                        bdsNV.Position = bdsNV.Find("MANV", manv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển nhân viên. Hãy thực hiện lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.NGANHANGDataSet.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }

            btnItemAdd.Enabled = btnItemEdit.Enabled = btnItemDelete.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = gctNV.Enabled = btnItemChuyenNV.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void btnItemExit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbChiNhanh.SelectedIndexChanged -= cmbChiNhanh_SelectedIndexChanged;
        }
    }
}
