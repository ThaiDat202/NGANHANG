﻿using System;
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
    public partial class frmChuyenTien : Form
    {
        int vitri = 0;
        public frmChuyenTien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.GD_CHUYENTIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.NGANHANGDataSet);

        }

        private void frmChuyenTien_Load(object sender, EventArgs e)
        {
            NGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoFrom' table. You can move, or remove it, as needed.
            this.infoFromTableAdapter.Connection.ConnectionString = Program.connstr;
            this.infoFromTableAdapter.Fill(this.NGANHANGDataSet.InfoFrom);
            // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoTo' table. You can move, or remove it, as needed.
            this.infoToTableAdapter.Connection.ConnectionString = Program.connstr;
            this.infoToTableAdapter.Fill(this.NGANHANGDataSet.InfoTo);

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
                // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
                this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
                // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoFrom' table. You can move, or remove it, as needed.
                this.infoFromTableAdapter.Connection.ConnectionString = Program.connstr;
                this.infoFromTableAdapter.Fill(this.NGANHANGDataSet.InfoFrom);
                // TODO: This line of code loads data into the 'NGANHANGDataSet.InfoTo' table. You can move, or remove it, as needed.
                this.infoToTableAdapter.Connection.ConnectionString = Program.connstr;
                this.infoToTableAdapter.Fill(this.NGANHANGDataSet.InfoTo);
            }
        }

        private void btnItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GD_CHUYENTIENBindingSource.CancelEdit();
            if (btnItemAdd.Enabled == false)
                GD_CHUYENTIENBindingSource.Position = vitri;
            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = pnlDetail.Enabled = false;
        }

        private void btnItemReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GD_CHUYENTIENTableAdapter.Fill(this.NGANHANGDataSet.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = GD_CHUYENTIENBindingSource.Position;
            pnlDetail.Enabled = btnItemSave.Enabled = btnItemUndo.Enabled = true;
            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = false;
            GD_CHUYENTIENBindingSource.AddNew();
            txtMANV.Text = Program.username;
        }

        private void btnItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                GD_CHUYENTIENBindingSource.EndEdit();
                GD_CHUYENTIENBindingSource.ResetCurrentItem();

                if (cmbSoTKChuyen.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn số tài khoản chuyển !", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTKChuyen.Focus();
                    return;
                }
                if (cmbSoTKNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn số tài khoản nhận !", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTKNhan.Focus();
                    return;
                }
                else if (cmbSoTKChuyen.Text == cmbSoTKNhan.Text)
                {
                    MessageBox.Show("Vui lòng chọn số tài khoản nhận khác !", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTKNhan.Focus();
                    return;
                }
                if (Convert.ToInt32(txtSoTien.EditValue) < 100000 || txtSoTien.EditValue == null)
                {
                    MessageBox.Show("Số tiền giao dịch tối thiểu phải là 100.000đ !", "Thông báo", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }

                string query = "EXEC SP_ChuyenTien '"
                                + cmbSoTKChuyen.SelectedValue.ToString().Trim() + "', '"
                                + cmbSoTKNhan.SelectedValue.ToString().Trim() + "', "
                                + txtSoTien.EditValue.ToString().Trim() + ", '"
                                + txtMANV.Text.ToString().Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(query);
                if (Program.myReader == null)
                    return;
                Program.myReader.Read();
                int check = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                if (check == 2)
                {
                    MessageBox.Show("Số tài khoản chuyển không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTKChuyen.Focus();
                    return;
                }
                if (check == 3)
                {
                    MessageBox.Show("Số tài khoản nhận không tồn tại !", "Thông báo", MessageBoxButtons.OK);
                    cmbSoTKNhan.Focus();
                    return;
                }
                if (check == 4)
                {
                    MessageBox.Show("Số dư tài khoản chuyển không đủ !", "Thông báo", MessageBoxButtons.OK);
                    txtSoTien.Focus();
                    return;
                }
                if (check == 0)
                {
                    MessageBox.Show("Giao dịch thất bại !", "Thông báo", MessageBoxButtons.OK);
                }
                if (check == 1)
                {
                    MessageBox.Show("Giao dịch thành công !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                GD_CHUYENTIENBindingSource.RemoveCurrent();
                MessageBox.Show("Lỗi thực hiện giao dịch.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnItemAdd.Enabled = btnItemReload.Enabled = btnItemExit.Enabled = true;
            btnItemSave.Enabled = btnItemUndo.Enabled = false;
            pnlDetail.Enabled = false;
        }

        private void frmChuyenTien_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbChiNhanh.SelectedIndexChanged -= cmbChiNhanh_SelectedIndexChanged;
        }
    }
    
}
