using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKhachSan.UserControlForm
{
    public partial class User_DangKyPhong : UserControl
    {

        string connectionStrings = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;
        public User_DangKyPhong()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            DisableTextBoxes();
            LoadDanhSachPhong();
            cboMaphong.SelectedIndex = -1;
            LoadDanhSachKhachHang();
            cboMaKH.SelectedIndex = -1;
            LoadDanhSachNhanVien();
            cboMaNV.SelectedIndex = -1;
        }
        private void LoadDanhSachPhong()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "SELECT iMaPhong, sSoPhong FROM tblPhong";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaphong.DataSource = dt;
                cboMaphong.DisplayMember = "sSoPhong";
                cboMaphong.ValueMember = "iMaPhong";
            }
        }
        private void LoadDanhSachKhachHang()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "SELECT iMaKhach, sHoTen FROM tblKhach";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaKH.DataSource = dt;
                cboMaKH.DisplayMember = "sHoTen";
                cboMaKH.ValueMember = "iMaKhach";
                
            }
        }
        private void LoadDanhSachNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "SELECT iMaNV, sHoTen FROM tblNhanvien";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaNV.DataSource = dt;
                cboMaNV.DisplayMember = "sHoTen";
                cboMaNV.ValueMember = "iMaNV";
            }
        }

        private DataTable GetDangKy()
        {
            string procName = "spDangky_Get";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblDangky");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }
        }
        private void hienDanhSachDangKy()
        {
            DataTable t = GetDangKy();
            DataView v = new DataView(t);
            dgvDangky.AutoGenerateColumns = true;
            dgvDangky.DataSource = v;
        }
        private void User_DangKyPhong_Load(object sender, EventArgs e)
        {
            hienDanhSachDangKy();
        }

        private void dgvDangky_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDangky.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDangky.SelectedRows[0];
                txtMadangky.Text = selectedRow.Cells["Mã đặt phòng"].Value.ToString();
                cboMaphong.SelectedValue = selectedRow.Cells["Mã phòng"].Value.ToString();
                cboMaKH.SelectedValue = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                cboMaNV.SelectedValue = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                dNgaydatphong.Value = Convert.ToDateTime(selectedRow.Cells["Ngày đặt phòng"].Value);
                dNgaynhanphong.Value = Convert.ToDateTime(selectedRow.Cells["Ngày nhận phòng"].Value); 
                dNgaytraphong.Value = Convert.ToDateTime(selectedRow.Cells["Ngày trả phòng"].Value);
            }
        }
        private void EnableTextBoxes()
        {
            txtMadangky.Enabled = false;
            cboMaphong.Enabled = true;
            cboMaKH.Enabled = true;
            cboMaNV.Enabled = true;
            dNgaydatphong.Enabled = true;
            dNgaynhanphong.Enabled = true;
            dNgaytraphong.Enabled = true;
        }
        private void DisableTextBoxes()
        {
            txtMadangky.Enabled = false;
            cboMaphong.Enabled = false;
            cboMaKH.Enabled = false;
            cboMaNV.Enabled = false;
            dNgaydatphong.Enabled = false;
            dNgaynhanphong.Enabled = false;
            dNgaytraphong.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnNhan.Enabled = false;
            btnHuy.Enabled = false;
            btnTimkiem.Enabled = false;
            btnDat.Enabled = false;
            btnLuu.Text = "ĐẶT";
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "ĐẶT")
            {
                if (cboMaphong.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Số phòng chưa được chọn!");
                    return;
                }
                if (cboMaKH.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Khách hàng chưa được chọn!");
                    return;
                }
                if (cboMaNV.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Nhân viên chưa được chọn!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dNgaydatphong.Text))
                {
                    MessageBox.Show("Lỗi: Ngày tháng không được để trống");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dNgaynhanphong.Text))
                {
                    MessageBox.Show("Lỗi: Ngày tháng không được để trống");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dNgaytraphong.Text))
                {
                    MessageBox.Show("Lỗi: Ngày tháng không được để trống");
                    return;
                }
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    cnn.Open();
                    SqlTransaction transaction = cnn.BeginTransaction();
                    try
                    {
                        string insert = "spDangky_Insert";
                        using (SqlCommand cmdInsert = new SqlCommand(insert, cnn, transaction))
                        {
                            cmdInsert.CommandType = CommandType.StoredProcedure;
                            cmdInsert.Parameters.AddWithValue("@maphong", cboMaphong.SelectedValue);
                            cmdInsert.Parameters.AddWithValue("@makh", cboMaKH.SelectedValue);
                            cmdInsert.Parameters.AddWithValue("@manv", cboMaNV.SelectedValue);
                            cmdInsert.Parameters.AddWithValue("@ngaydatphong", dNgaydatphong.Value);
                            cmdInsert.Parameters.AddWithValue("@ngaynhanphong", dNgaynhanphong.Value);
                            cmdInsert.Parameters.AddWithValue("@ngaytraphong", dNgaytraphong.Value);
                            cmdInsert.ExecuteNonQuery();
                        }
                        string update = "spDangky_UpdateTT";
                        using (SqlCommand cmdUpdate = new SqlCommand(update, cnn, transaction))
                        {
                            cmdUpdate.CommandType = CommandType.StoredProcedure;
                            cmdUpdate.Parameters.AddWithValue("@maphong", cboMaphong.SelectedValue);
                            cmdUpdate.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show("Đặt phòng thành công!");
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
                btnLuu.Text = "LƯU";
                hienDanhSachDangKy();
                btnNhan.Enabled = true;
                btnHuy.Enabled = true;
                btnTimkiem.Enabled = true;
                btnDat.Enabled = true;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string procName = "spDangky_Update";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                cnn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@madangky", txtMadangky.Text);
                        cmd.Parameters.AddWithValue("@maphong", cboMaphong.SelectedValue);
                        cmd.Parameters.AddWithValue("@ngaynhanphong", dNgaynhanphong.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Nhận phòng thành công!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                cnn.Open();
                SqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    string delete = "spDangky_Delete";
                    using (SqlCommand cmdDelete = new SqlCommand(delete, cnn, transaction))
                    {
                        cmdDelete.CommandType = CommandType.StoredProcedure;
                        cmdDelete.Parameters.AddWithValue("@madangky", txtMadangky.Text);
                        cmdDelete.Parameters.AddWithValue("@maphong", cboMaphong.SelectedValue);
                        cmdDelete.ExecuteNonQuery();
                    }
                    string update = "spDangky_UpdateTT1";
                    using (SqlCommand cmdUpdate = new SqlCommand(update, cnn, transaction))
                    {
                        cmdUpdate.CommandType = CommandType.StoredProcedure;
                        cmdUpdate.Parameters.AddWithValue("@maphong", cboMaphong.SelectedValue);
                        cmdUpdate.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Hủy đặt phòng thành công!");
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            
        }
    }
}
