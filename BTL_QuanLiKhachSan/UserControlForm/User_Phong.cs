using BTL_QuanLiKhachSan.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            
        }
        private void InitializeControls()
        {
            txtMaphong.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            gbTimkiem.Enabled = false;
            DisableTextBoxes();
            LoadDanhSachLoaiPhong();
            LoadDanhSachTrangThai();
            cboLoaiphong.SelectedIndex = -1;
            cboTrangthai.SelectedIndex = -1;
        }
        private void LoadDanhSachLoaiPhong()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string proc = "LoadDSLP";
                SqlDataAdapter da = new SqlDataAdapter(proc, cnn);
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
                string proc = "LoadDSTT";
                SqlDataAdapter da = new SqlDataAdapter(proc, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboTrangthai.DataSource = dt;
                cboTrangthai.DisplayMember = "sTrangThai";
                cboTrangthai.ValueMember = "sTrangThai";
            }
        }
        private void DisableTextBoxes()
        {
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
            txtSophong.Leave += txtSophong_Leave;
            txtDongia.Leave += txtDongia_Leave;
            cboLoaiphong.Leave += cboLoaiphong_Leave;
            cboTrangthai.Leave += cboTrangthai_Leave;
        }
        private void KiemTraLoaiPhong()
        {
            if (cboLoaiphong.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboLoaiphong.Text))
            {
                errorProvider1.SetError(cboLoaiphong, "Loại phòng không được để trống!");
               
                return;
            }
            else
            {
                errorProvider1.SetError(cboLoaiphong, "");
            }
        }
        private void cboLoaiphong_Leave(object sender, EventArgs e)
        {
            KiemTraLoaiPhong();
        }
        private void KiemTraTrangThai()
        {
            if (cboTrangthai.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboTrangthai.Text))
            {
                errorProvider1.SetError(cboTrangthai, "Trạng thái không được để trống!");
               
                return;
            }
            else
            {
                errorProvider1.SetError(cboTrangthai, "");
            }
        }
        private void cboTrangthai_Leave(object sender, EventArgs e)
        {
            KiemTraTrangThai();
        }
        private void KiemTraDonGia()
        {
            string dongiaText = txtDongia.Text.Trim();

            if (string.IsNullOrWhiteSpace(dongiaText))
            {
                errorProvider1.SetError(txtDongia, "Đơn giá không được để trống!");
                
                return;
            }
            else
            {
                errorProvider1.SetError(txtDongia, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra chỉ chứa số hoặc số thập phân
            if (!decimal.TryParse(dongiaText, out decimal dongia) || dongia <= 0)
            {
                errorProvider1.SetError(txtDongia, "Đơn giá phải là số và lớn hơn 0!");
               
                return;
            }
            else
            {
                errorProvider1.SetError(txtDongia, ""); // Xóa lỗi nếu hợp lệ
            }
        }
        private void txtDongia_Leave(object sender, EventArgs e)
        {
            KiemTraDonGia();
        }
        //private bool KiemTraTrungSoPhong(string sophong)
        //{
        //    string proc = "TestSP";
        //    using (SqlConnection cnn = new SqlConnection(connectionStrings))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(proc, cnn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@sophong", sophong);
        //            try
        //            {
        //                cnn.Open();
        //                int count = (int)cmd.ExecuteScalar();
        //                return count > 0;
        //            }
        //            catch (SqlException ex)
        //            {
        //                MessageBox.Show("Lỗi kiểm tra số phòng: " + ex.Message);
        //                return false;
        //            }
        //        }
        //    }
        //}
        private void KiemTraSoPhong()
        {
            string sophong = txtSophong.Text.Trim();

            // Nếu để trống, hiển thị lỗi
            if (string.IsNullOrWhiteSpace(sophong))
            {
                errorProvider1.SetError(txtSophong, "Số phòng không được để trống!");
              
                return;
            }
            else
            {
                errorProvider1.SetError(txtSophong, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra chỉ chứa số
            if (!sophong.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSophong, "Số phòng chỉ được chứa ký tự số!");
           
                return;
            }
            else
            {
                errorProvider1.SetError(txtSophong, ""); // Xóa lỗi nếu hợp lệ
            }
            
            

        }
        private void txtSophong_Leave(object sender, EventArgs e)
        {
            KiemTraSoPhong();
        }
        private bool KiemTraLoiThem()
        {
            KiemTraSoPhong();
            KiemTraDonGia();
            KiemTraLoaiPhong();
            KiemTraTrangThai();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSophong)))
                loiInputs.Add(txtSophong);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtDongia)))
                loiInputs.Add(txtDongia);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(cboLoaiphong)))
                loiInputs.Add(cboLoaiphong);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(cboTrangthai)))
                loiInputs.Add(cboTrangthai);

            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi thêm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnSua.Enabled = false;
            btnBaoCao.Enabled = false;
            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Text = "THÊM";
            txtSophong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnThem.Enabled = false;
            btnBaoCao.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnTimkiem.Enabled = false;

            if (dgvPhong.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPhong.SelectedRows[0];
                var data = selectedRow.DataBoundItem as DataRowView;
                if (data != null)
                {
                    txtMaphong.Text = data["Mã phòng"].ToString();
                    txtSophong.Text = data["Số phòng"].ToString();
                    txtDongia.Text = data["Đơn giá"].ToString();
                    cboLoaiphong.SelectedValue = data["Loại phòng"].ToString();
                    cboTrangthai.SelectedValue = data["Trạng thái"].ToString();
                }
                btnLuu.Text = "CẬP NHẬT";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "THÊM")
            {
                if (KiemTraLoiThem())
                {
                    //if (KiemTraTrungSoPhong(txtSophong.Text.Trim()))
                    //{
                    //    errorProvider1.SetError(txtSophong, "Số phòng đã tồn tại!");
                    //    txtSophong.Focus();
                    //}
                    //else
                    //{
                    //    errorProvider1.SetError(txtSophong, ""); // Xóa lỗi nếu hợp lệ
                    //}
                    string procName = "spPhong_Insert";
                    using (SqlConnection cnn = new SqlConnection(connectionStrings))
                    {
                        using (SqlCommand cmd = new SqlCommand(procName, cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sophong", txtSophong.Text);
                            cmd.Parameters.AddWithValue("@loaiphong", cboLoaiphong.SelectedValue);
                            cmd.Parameters.AddWithValue("@trangthai", cboTrangthai.SelectedValue);
                            cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);
                            try
                            {
                                cnn.Open();
                                cmd.ExecuteNonQuery();
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
                    btnBaoCao.Enabled = true;
                    btnTimkiem.Enabled = true;
                    btnThem.Enabled = true;
                }
            }
            if (btnLuu.Text == "CẬP NHẬT")
            {
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
                        cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                                
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
                btnBaoCao.Enabled = true;
                btnTimkiem.Enabled = true;
                
            }
            if(btnLuu.Text == "LƯU")
            {
                ResetTextBoxes();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBaoCao.Enabled = true;
                btnTimkiem.Enabled = true;
            }
        }
        private bool KiemTraLoiTimKiemTheoSoPhong()
        {
            KiemTraSoPhong();
            List<Control> loiInputs = new List<Control>();
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSophong)))
                loiInputs.Add(txtSophong);
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi tìm kiếm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KiemTraLoiTimKiemTheoLoaiPhong()
        {
            KiemTraLoaiPhong();
            List<Control> loiInputs = new List<Control>();
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSophong)))
                loiInputs.Add(txtSophong);
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi tìm kiếm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KiemTraLoiTimKiemTheoTrangThai()
        {
            KiemTraTrangThai();
            List<Control> loiInputs = new List<Control>();
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSophong)))
                loiInputs.Add(txtSophong);
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi tìm kiếm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnBaoCao.Enabled = false;
            gbTimkiem.Enabled = true;
            if (rbtnSoPhong.Checked)
            {
                if (KiemTraLoiTimKiemTheoSoPhong())
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
            }
            else if (rbtnLoaiPhong.Checked)
            {
                if (KiemTraLoiTimKiemTheoLoaiPhong())
                {
                    string searchText = cboLoaiphong.Text.Trim();
                    SearchLoaiPhong(searchText);
                }
            }
            else if (rbtnTrangThai.Checked)
            {
                if (KiemTraLoiTimKiemTheoTrangThai())
                {
                    string searchText = cboTrangthai.Text.Trim();
                    SearchTrangThai(searchText);
                }
            }

        }
        private void SearchLoaiPhong(string keyword)
        {
            string proc = "SearchLP";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Keyword", keyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPhong.DataSource = dt;
                }
                
            }
        }
        private void SearchTrangThai(string keyword)
        {
            string proc = "SearchTT";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Keyword", keyword);
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
            errorProvider1.Clear();
            txtSophong.Focus();
        }

        private void rbtnLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiphong.Enabled = true;
            cboTrangthai.Enabled = false;
            cboTrangthai.SelectedIndex = -1;
            txtSophong.Enabled = false;
            txtSophong.Text = string.Empty;
            errorProvider1.Clear();
            cboLoaiphong.Focus();
        }

        private void rbtnTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            cboTrangthai.Enabled = true;
            cboLoaiphong.Enabled = false;
            cboLoaiphong.SelectedIndex = -1;
            txtSophong.Enabled = false;
            txtSophong.Text = string.Empty;
            errorProvider1.Clear();
            cboTrangthai.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                cnn.Open();
                //string proc = "ReportTT";
                string proc = "ReportPhong";
                using (SqlCommand cmd = new SqlCommand(proc, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@trangthai", cboTrangthai.SelectedValue.ToString());
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);
                        Phong rpt = new Phong();
                        rpt.SetDataSource(table);
                        FormInBaoCao form = new FormInBaoCao();
                        form.crv1.ReportSource = rpt;
                        form.ShowDialog();
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ResetTextBoxes();
            DisableTextBoxes();
            gbTimkiem.Enabled = false;

            btnTimkiem.Enabled = true;
            btnBaoCao.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;


            rbtnLoaiPhong.Checked = false;
            rbtnTrangThai.Checked = false;
            if (btnLuu.Text == "CẬP NHẬT")
            {
                btnLuu.Text = "LƯU";
            }
            if (btnLuu.Text == "THÊM")
            {
                btnLuu.Text = "LƯU";
            }
            hienDanhSachPhong();
        }
    }
}
