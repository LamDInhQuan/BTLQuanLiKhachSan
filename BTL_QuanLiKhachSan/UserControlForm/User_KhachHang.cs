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
    public partial class User_KhachHang : UserControl
    {
        string connectionStrings = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;

        public User_KhachHang()
        {
            InitializeComponent();
            DisableTextBoxes();
            gbTimkiem.Enabled = false;
        }
        
        private void DisableTextBoxes()
        {
            txtMaKH.Enabled = false;
            txtHoten.Enabled = false;
            txtCMND.Enabled = false;
            txtDiachi.Enabled = false;
            txtSDT.Enabled = false;
            txtGhichu.Enabled = false;
            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;
            dNgaysinh.Enabled = false;
        }
        private void ResetTextBoxes()
        {
            txtMaKH.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtGhichu.Text = string.Empty;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            dNgaysinh.Text = string.Empty;
        }
        private void EnableTextBoxes()
        {
            txtMaKH.Enabled = false;
            txtHoten.Enabled = true;
            txtCMND.Enabled = true;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhichu.Enabled = true;
            rbtnNam.Enabled = true;
            rbtnNu.Enabled = true;
            dNgaysinh.Enabled = true;
        }
        private DataTable GetKhachHang()
        {
            string procName = "spKH_Get";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblKhach");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
            }
        }

        private void hienDanhSachKH()
        {
            DataTable t = GetKhachHang();
            DataView v = new DataView(t);
            dgvKH.AutoGenerateColumns = true;
            dgvKH.DataSource = v;
        }
        private void User_KhachHang_Load(object sender, EventArgs e)
        {
            hienDanhSachKH();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "THÊM")
            {
                if (string.IsNullOrWhiteSpace(txtHoten.Text))
                {
                    MessageBox.Show("Lỗi: Họ tên không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCMND.Text))
                {
                    MessageBox.Show("Lỗi: CMND không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDiachi.Text))
                {
                    MessageBox.Show("Lỗi: Địa chỉ không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Lỗi: Số điện thoại không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dNgaysinh.Text))
                {
                    MessageBox.Show("Lỗi: Ngày sinh không được để trống!");
                    return;
                }
                string procName = "spKH_Insert";
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@cmnd", txtCMND.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dNgaysinh.Value);
                        cmd.Parameters.AddWithValue("@gioitinh", rbtnNam.Checked);
                        cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@ghichu", txtGhichu.Text);
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
                hienDanhSachKH();
                ResetTextBoxes();
                DisableTextBoxes();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTimkiem.Enabled = true;
                btnThem.Enabled = true;
            }
            if (btnLuu.Text == "CẬP NHẬT")
            {
                if (string.IsNullOrWhiteSpace(txtHoten.Text))
                {
                    MessageBox.Show("Lỗi: Họ tên không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCMND.Text))
                {
                    MessageBox.Show("Lỗi: CMND không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDiachi.Text))
                {
                    MessageBox.Show("Lỗi: Địa chỉ không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Lỗi: Số điện thoại không được để trống!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(dNgaysinh.Text))
                {
                    MessageBox.Show("Lỗi: Ngày sinh không được để trống!");
                    return;
                }
                string procName = "spKH_Update";
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@makhach", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@cmnd", txtCMND.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dNgaysinh.Value);
                        cmd.Parameters.AddWithValue("@gioitinh", rbtnNam.Checked);
                        cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@ghichu", txtGhichu.Text);
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
                hienDanhSachKH();
                DisableTextBoxes();
                ResetTextBoxes();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = false;
            if (btnSua.Text == "SỬA")
            {
                if (dgvKH.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvKH.SelectedRows[0];
                    txtMaKH.Text = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                    txtHoten.Text = selectedRow.Cells["Họ tên"].Value.ToString();
                    txtCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                    txtDiachi.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                    txtSDT.Text = selectedRow.Cells["Số điện thoại"].Value.ToString();
                    txtGhichu.Text = selectedRow.Cells["Ghi chú"].Value.ToString();
                    rbtnNam.Checked = !Convert.ToBoolean(selectedRow.Cells["Giới tính"].Value);
                    rbtnNu.Checked = Convert.ToBoolean(selectedRow.Cells["Giới tính"].Value);
                    dNgaysinh.Value = Convert.ToDateTime(selectedRow.Cells["Ngày sinh"].Value);
                    btnLuu.Text = "CẬP NHẬT";
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            gbTimkiem.Enabled = true;
            if (rbtnHoten.Checked)
            {
                DataTable t = GetKhachHang();
                DataView v = new DataView(t);
                List<string> filterConditions = new List<string>();
                if (!string.IsNullOrEmpty(txtHoten.Text))
                    filterConditions.Add($"[Họ tên] LIKE '*{txtHoten.Text.Trim()}*'");

                if (filterConditions.Count > 0)
                {
                    string filterString = string.Join(" AND ", filterConditions);
                    v.RowFilter = filterString;
                }
                dgvKH.DataSource = v;

            }
            else if (rbtnCMND.Checked)
            {
                DataTable t = GetKhachHang();
                DataView v = new DataView(t);
                List<string> filterConditions = new List<string>();
                if (!string.IsNullOrEmpty(txtCMND.Text))
                    filterConditions.Add($"[CMND] LIKE '*{txtCMND.Text.Trim()}*'");

                if (filterConditions.Count > 0)
                {
                    string filterString = string.Join(" AND ", filterConditions);
                    v.RowFilter = filterString;
                }
                dgvKH.DataSource = v;

            }
            else if (rbtnSDT.Checked)
            {
                DataTable t = GetKhachHang();
                DataView v = new DataView(t);
                List<string> filterConditions = new List<string>();
                if (!string.IsNullOrEmpty(txtSDT.Text))
                    filterConditions.Add($"[Số điện thoại] LIKE '*{txtSDT.Text.Trim()}*'");

                if (filterConditions.Count > 0)
                {
                    string filterString = string.Join(" AND ", filterConditions);
                    v.RowFilter = filterString;
                }
                dgvKH.DataSource = v;
            }
        }

        private void rbtnHoten_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.Enabled = true;
            txtCMND.Enabled = false;
            txtCMND.Text = string.Empty;
            txtSDT.Enabled = false;
            txtSDT.Text = string.Empty;
            txtHoten.Focus();
        }

        private void rbtnCMND_CheckedChanged(object sender, EventArgs e)
        {
            txtCMND.Enabled = true;
            txtSDT.Enabled = false;
            txtSDT.Text = string.Empty;
            txtHoten.Enabled = false;
            txtHoten.Text = string.Empty;
            txtCMND.Focus();
        }

        private void rbtnSDT_CheckedChanged(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            txtCMND.Enabled = false;
            txtCMND.Text = string.Empty;
            txtHoten.Enabled = false;
            txtHoten.Text = string.Empty;
            txtSDT.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello.");
        }
    }
}
