using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKhachSan.UserControlForm
{
    public partial class User_Phong : UserControl
    {
        string connectionStrings = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;
        public User_Phong()
        {
            InitializeComponent();
            InitializeControls();
            gbTimKiem.Enabled = false;
        }
        private void InitializeControls()
        {
            DisableTextBoxes();
            LoadDanhSachLoaiPhong();
            LoadDanhSachTrangThai();
            cboLoaiphong.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
        }
        private DataTable GetPhong()
        {
            string procName = "spPhong_Get";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblPhong");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }
        }

        private void hienDanhSachPhong()
        {
            DataTable t = GetPhong();
            DataView v = new DataView(t);
            dgvPhong.AutoGenerateColumns = true;
            dgvPhong.DataSource = v;
        }
        private void User_Phong_Load(object sender, EventArgs e)
        {
            hienDanhSachPhong();
        }
        private void LoadDanhSachLoaiPhong()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "SELECT DISTINCT sLoaiPhong FROM tblPhong";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboLoaiphong.DataSource = dt;
                cboLoaiphong.DisplayMember = "sLoaiPhong";
                cboLoaiphong.ValueMember = "sLoaiPhong";
            }
        }
        private void LoadDanhSachTrangThai()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "SELECT DISTINCT sTrangThai FROM tblPhong";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboTrangthai.DataSource = dt;
                cboTrangthai.DisplayMember = "sTrangThai";
                cboTrangthai.ValueMember = "sTrangThai";
            }
        }
        private void DisableTextBoxes()
        {
            txtMaphong.Enabled = false;
            txtSophong.Enabled = false;
            txtDongia.Enabled = false;
            cboLoaiphong.Enabled = false;
            cboTrangthai.Enabled = false;
        }
        private void ResetTextBoxes()
        {
            txtMaphong.Text = string.Empty;
            txtSophong.Text = string.Empty;
            txtDongia.Text = string.Empty;
            cboLoaiphong.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
        }
        private void EnableTextBoxes()
        {
            txtSophong.Enabled = true;
            txtDongia.Enabled = true;
            cboLoaiphong.Enabled = true;
            cboTrangthai.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Text = "THÊM";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            if (btnSua.Text == "SỬA")
            {
                if (dgvPhong.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvPhong.SelectedRows[0];
                    txtMaphong.Text = selectedRow.Cells["Mã phòng"].Value.ToString();
                    txtSophong.Text = selectedRow.Cells["Số phòng"].Value.ToString();
                    txtDongia.Text = selectedRow.Cells["Đơn giá"].Value.ToString();
                    cboLoaiphong.SelectedValue = selectedRow.Cells["Loại phòng"].Value.ToString();
                    cboTrangthai.SelectedValue = selectedRow.Cells["Trạng thái"].Value.ToString();

                    btnLuu.Text = "CẬP NHẬT";
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "THÊM")
            {
                if (string.IsNullOrWhiteSpace(txtSophong.Text))
                {
                    MessageBox.Show("Lỗi: Số phòng không được để trống!");
                    return;
                }
                if (cboLoaiphong.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Loại phòng chưa được chọn!");
                    return;
                }
                if (cboTrangthai.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Trạng thái chưa được chọn!");
                    return;
                }
                decimal dongia;
                if (!decimal.TryParse(txtDongia.Text, out dongia))
                {
                    MessageBox.Show("Lỗi: Đơn giá không hợp lệ! Vui lòng nhập số.");
                    return;
                }
                string procName = "spPhong_Insert";
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sophong", txtSophong.Text);
                        cmd.Parameters.AddWithValue("@loaiphong", cboLoaiphong.SelectedValue);
                        cmd.Parameters.AddWithValue("@trangthai", cboTrangthai.SelectedValue);
                        cmd.Parameters.AddWithValue("@dongia", dongia);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Dữ liệu đã được thêm thành công!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi SQL: " + ex.Message);
                        }
                    }
                }
                btnLuu.Text = "LƯU";
                hienDanhSachPhong();
                ResetTextBoxes();
                DisableTextBoxes();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTimkiem.Enabled = true;
                btnThem.Enabled = true;
            }
            if (btnLuu.Text == "CẬP NHẬT")
            {
                if (string.IsNullOrWhiteSpace(txtSophong.Text))
                {
                    MessageBox.Show("Lỗi: Số phòng không được để trống!");
                    return;
                }
                if (cboLoaiphong.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Loại phòng chưa được chọn!");
                    return;
                }
                if (cboTrangthai.SelectedValue == null)
                {
                    MessageBox.Show("Lỗi: Trạng thái chưa được chọn!");
                    return;
                }
                decimal dongia;
                if (!decimal.TryParse(txtDongia.Text, out dongia))
                {
                    MessageBox.Show("Lỗi: Đơn giá không hợp lệ! Vui lòng nhập số.");
                    return;
                }
                string procName = "spPhong_Update";
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maphong", txtMaphong.Text);
                        cmd.Parameters.AddWithValue("@sophong", txtSophong.Text);
                        cmd.Parameters.AddWithValue("@loaiphong", cboLoaiphong.SelectedValue);
                        cmd.Parameters.AddWithValue("@trangthai", cboTrangthai.SelectedValue);
                        cmd.Parameters.AddWithValue("@dongia", dongia);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi SQL: " + ex.Message);
                        }
                    }
                }
                btnLuu.Text = "LƯU";
                hienDanhSachPhong();
                DisableTextBoxes();
                ResetTextBoxes();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            gbTimKiem.Enabled = true;
            if (rbtnSoPhong.Checked)
            {
                DataTable t = GetPhong();
                DataView v = new DataView(t);
                List<string> filterConditions = new List<string>();
                if (!string.IsNullOrEmpty(txtSophong.Text))
                    filterConditions.Add($"[Số phòng] LIKE '*{txtSophong.Text.Trim()}*'");

                if (filterConditions.Count > 0)
                {
                    string filterString = string.Join(" AND ", filterConditions);
                    v.RowFilter = filterString;
                }
                dgvPhong.DataSource = v;
                
            }
            else if (rbtnLoaiPhong.Checked)
            {
                string searchText = cboLoaiphong.Text.Trim();
                SearchLoaiPhong(searchText);
                
            }
            else if (rbtnTrangThai.Checked)
            {
                string searchText = cboTrangthai.Text.Trim();
                SearchTrangThai(searchText);
                
            }

        }
        private void SearchLoaiPhong(string keyword)
        {
            string query = "SELECT * FROM tblPhong WHERE sLoaiPhong LIKE @Keyword";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPhong.DataSource = dt;
                }
                
            }
        }
        private void SearchTrangThai(string keyword)
        {
            string query = "SELECT * FROM tblPhong WHERE sTrangThai LIKE @Keyword";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    dgvPhong.DataSource = dt;
                }

            }
        }

        private void rbtnSoPhong_CheckedChanged(object sender, EventArgs e)
        {
            txtSophong.Enabled = true;
            cboLoaiphong.Enabled = false;
            cboLoaiphong.SelectedIndex = -1;
            cboTrangthai.Enabled = false;
            cboTrangthai.SelectedIndex = -1;
            txtSophong.Focus();        
        }

        private void rbtnLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiphong.Enabled = true;
            cboTrangthai.Enabled = false;
            cboTrangthai.SelectedIndex = -1;
            txtSophong.Enabled = false;
            txtSophong.Text = string.Empty;
            cboLoaiphong.Focus();
        }

        private void rbtnTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            cboTrangthai.Enabled = true;
            cboLoaiphong.Enabled = false;
            cboLoaiphong.SelectedIndex = -1;
            txtSophong.Enabled = false;
            txtSophong.Text = string.Empty;
            cboTrangthai.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
