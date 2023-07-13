using DevExpress.ChartRangeControlClient.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NganHang
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void layDSPM(String query)
        {
            DataTable data = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn_publisher); // tạo ra một adapter kết nối tới csdl với query thông qua conn_publisher
            dataAdapter.Fill(data);// đổ data lấy được vào datatable tương ứng với các row và các column có tên tương ứng trong csdl
            conn_publisher.Close();
            Program.bds_dspm.DataSource = data;
    
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN"; cmbChiNhanh.ValueMember = "TENSERVER";

        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("\nLỗi kết nối cơ sở dữ liệu gốc.\nBạn xem lại Tên Server và tên của Publisher, và tên CSDL trong chuỗi kết nối.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception ex)
            {

            }

        }
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            //Kết nối về sever tương ứng
            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return; //Thử kết nối, nếu k log dc thì return

            //Kết nối thành công thì gán cho DN
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String strLenh = "EXEC SP_DangNhap '" + Program.mlogin + "'";
            
            Program.myReader = Program.ExecSqlDataReader(strLenh); ;
            if (Program.myReader == null) return;

            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản bạn nhập không có quyền truy cập dữ liệu.\nVui lòng xem lại username và password.", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã NV: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ Tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            
            
            Program.frmChinh.btnDangNhap.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = true;
            Program.frmChinh.HienThiMenu();
            Close();
        }

    private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmChinh.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM Get_Subcribers");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
        }
    }
}
