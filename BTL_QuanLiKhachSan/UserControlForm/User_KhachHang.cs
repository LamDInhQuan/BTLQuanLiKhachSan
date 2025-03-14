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
using TheArtOfDevHtmlRenderer.Adapters;

namespace BTL_QuanLiKhachSan.UserControlForm
{
    public partial class User_KhachHang : UserControl
    {
        string connectionStrings = ConfigurationManager.ConnectionStrings["db_Shop4Training"].ConnectionString;

        public User_KhachHang()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            txtMaKH.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            gbTimkiem.Enabled = false;
            DisableTextBoxes();
        }
        private void DisableTextBoxes()
        {
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
            txtHoten.Leave += txtHoTen_Leave;
            txtSDT.Leave += txtSDT_Leave;
            txtDiachi.Leave += txtDiaChi_Leave;
            txtCMND.Leave += txtCMND_Leave;
            dNgaysinh.Leave += dNgaysinh_Leave;
            rbtnNam.Leave += rbtnNam_Leave;
            rbtnNu.Leave += rbtnNu_Leave;
        }
        //private bool KiemTraTrungCMND(string cmnd)
        //{
        //    string proc = "TestCMND";
        //    using (SqlConnection cnn = new SqlConnection(connectionStrings))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(proc, cnn))
        //        {
        //            cmd.Parameters.AddWithValue("@cmnd", cmnd);
        //            try
        //            {
        //                cnn.Open();
        //                int count = (int)cmd.ExecuteScalar();
        //                return count > 0;
        //            }
        //            catch (SqlException ex)
        //            {
        //                MessageBox.Show("Lỗi kiểm tra số CMND: " + ex.Message);
        //                return false;
        //            }
        //        }
        //    }
        //}
        private void KiemTraCMND()
        {
            string cmnd = txtCMND.Text.Trim();

            // Nếu để trống, hiển thị lỗi
            if (string.IsNullOrWhiteSpace(cmnd))
            {
                errorProvider1.SetError(txtCMND, "CMND không được để trống!");

                return;
            }
            else
            {
                errorProvider1.SetError(txtCMND, ""); // Xóa lỗi nếu hợp lệ
            }

            if (cmnd.Length != 9 && cmnd.Length != 12)
            {
                errorProvider1.SetError(txtCMND, "CMND phải có 9 hoặc 12 số!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCMND, ""); // Xóa lỗi nếu hợp lệ
            }
            // Kiểm tra chỉ chứa số
            if (!cmnd.All(char.IsDigit))
            {
                errorProvider1.SetError(txtCMND, "CMND chỉ được chứa ký tự số!");

                return;
            }
            else
            {
                errorProvider1.SetError(txtCMND, ""); // Xóa lỗi nếu hợp lệ
            }

        }
        //private void KiemTraTrungCMND()
        //{
        //    string cmnd = txtCMND.Text.Trim();
        //    
        //    if (KiemTraTrungCMND(cmnd))
        //    {
        //        errorProvider1.SetError(txtCMND, "CMND đã tồn tại!");

        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtCMND, ""); // Xóa lỗi nếu hợp lệ
        //    }
        //}
        private void txtCMND_Leave(object sender, EventArgs e)
        {
            KiemTraCMND();

        }
        private void KiemTraHoTen()
        {
            string hoten = txtHoten.Text.Trim();

            // Kiểm tra không để trống
            if (string.IsNullOrWhiteSpace(hoten))
            {
                errorProvider1.SetError(txtHoten, "Họ tên không được để trống!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHoten, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra độ dài tối thiểu 2 ký tự
            if (hoten.Length < 2)
            {
                errorProvider1.SetError(txtHoten, "Họ tên phải có ít nhất 2 ký tự!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHoten, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra chỉ chứa chữ cái (có dấu hoặc không)
            Regex regex = new Regex(@"^[\p{L}\s]+$"); // Chỉ cho phép chữ cái và khoảng trắng
            if (!regex.IsMatch(hoten))
            {
                errorProvider1.SetError(txtHoten, "Họ tên chỉ được chứa chữ cái và khoảng trắng!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHoten, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            KiemTraHoTen();
        }
        // Hàm kiểm tra địa chỉ hợp lệ
        private void KiemTraDiaChi()
        {
            string diachi = txtDiachi.Text.Trim();

            // Kiểm tra không để trống
            if (string.IsNullOrWhiteSpace(diachi))
            {
                errorProvider1.SetError(txtDiachi, "Địa chỉ không được để trống!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDiachi, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra độ dài tối thiểu 5 ký tự
            if (diachi.Length < 5)
            {
                errorProvider1.SetError(txtDiachi, "Địa chỉ phải có ít nhất 5 ký tự!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDiachi, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra chỉ chứa chữ cái, số, khoảng trắng, dấu chấm, dấu phẩy
            Regex regex = new Regex(@"^[\p{L}0-9\s,.-]+$");
            if (!regex.IsMatch(diachi))
            {
                errorProvider1.SetError(txtDiachi, "Địa chỉ chỉ được chứa chữ, số, dấu chấm, dấu phẩy!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDiachi, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        // Gọi kiểm tra khi rời khỏi ô nhập địa chỉ
        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            KiemTraDiaChi();
        }
        // Hàm kiểm tra số điện thoại hợp lệ
        private void KiemTraSoDienThoai()
        {
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra không để trống
            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSDT, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra độ dài (10 hoặc 11 số)
            if (sdt.Length < 10 || sdt.Length > 11)
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có 10 hoặc 11 chữ số!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSDT, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra chỉ chứa số và bắt đầu bằng 0
            Regex regex = new Regex(@"^0\d{9,10}$");
            if (!regex.IsMatch(sdt))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại chỉ chứa số và phải bắt đầu bằng 0!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSDT, ""); // Xóa lỗi nếu hợp lệ
            }
        }
        private void txtSDT_Leave(object sender, EventArgs e)
        {
            KiemTraSoDienThoai();
        }
        // Hàm kiểm tra ngày sinh hợp lệ
        private void KiemTraNgaySinh()
        {
            DateTime ngaySinh = dNgaysinh.Value;
            DateTime ngayHienTai = DateTime.Now;

            // Kiểm tra ngày sinh không vượt quá ngày hiện tại
            if (ngaySinh > ngayHienTai)
            {
                errorProvider1.SetError(dNgaysinh, "Ngày sinh không được lớn hơn ngày hiện tại!");
                return;
            }
            else
            {
                errorProvider1.SetError(dNgaysinh, ""); // Xóa lỗi nếu hợp lệ
            }

            // Kiểm tra tuổi (tối thiểu 18 tuổi)
            int tuoi = ngayHienTai.Year - ngaySinh.Year;

            // Điều chỉnh nếu chưa đến sinh nhật năm nay
            if (ngaySinh.Date > ngayHienTai.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                errorProvider1.SetError(dNgaysinh, "Khách hàng phải từ 18 tuổi trở lên!");
                return;
            }
            else
            {
                errorProvider1.SetError(dNgaysinh, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        // Gọi kiểm tra khi rời khỏi ô nhập ngày sinh
        private void dNgaysinh_Leave(object sender, EventArgs e)
        {
            KiemTraNgaySinh();
        }
        // Hàm kiểm tra giới tính với RadioButton
        private bool KiemTraGioiTinh()
        {
            if (!rbtnNam.Checked && !rbtnNu.Checked)
            {
                errorProvider1.SetError(rbtnNam, "Vui lòng chọn giới tính!");
                errorProvider1.SetError(rbtnNu, "Vui lòng chọn giới tính!");
                return false;
            }
            else
            {
                errorProvider1.SetError(rbtnNam, ""); // Xóa lỗi nếu hợp lệ
                errorProvider1.SetError(rbtnNu, "");  // Xóa lỗi nếu hợp lệ
                return true;
            }
        }

        // Gọi kiểm tra khi rời khỏi ô nhập
        private void rbtnNam_Leave(object sender, EventArgs e)
        {
            KiemTraGioiTinh();
        }

        private void rbtnNu_Leave(object sender, EventArgs e)
        {
            KiemTraGioiTinh();
        }
        private bool KiemTraLoiThem()
        {
            KiemTraCMND();
            KiemTraDiaChi();
            KiemTraGioiTinh();
            KiemTraHoTen();
            KiemTraNgaySinh();
            KiemTraSoDienThoai();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCMND)))
                loiInputs.Add(txtCMND);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtDiachi)))
                loiInputs.Add(txtDiachi);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtHoten)))
                loiInputs.Add(txtHoten);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSDT)))
                loiInputs.Add(txtSDT);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(dNgaysinh)))
                loiInputs.Add(dNgaysinh);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(rbtnNam)))
                loiInputs.Add(rbtnNam);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(rbtnNu)))
                loiInputs.Add(rbtnNu);

            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi thêm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KiemTraLoiSua()
        {
            KiemTraCMND();
            KiemTraDiaChi();
            KiemTraGioiTinh();
            KiemTraHoTen();
            KiemTraNgaySinh();
            KiemTraSoDienThoai();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCMND)))
                loiInputs.Add(txtCMND);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtDiachi)))
                loiInputs.Add(txtDiachi);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtHoten)))
                loiInputs.Add(txtHoten);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSDT)))
                loiInputs.Add(txtSDT);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(dNgaysinh)))
                loiInputs.Add(dNgaysinh);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(rbtnNam)))
                loiInputs.Add(rbtnNam);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(rbtnNu)))
                loiInputs.Add(rbtnNu);

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
            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Text = "THÊM";
            txtHoten.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnThem.Enabled = false;
            btnTimkiem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            if (dgvKH.SelectedRows.Count > 0)
            {
                var selectedRow = dgvKH.SelectedRows[0];
                var data = selectedRow.DataBoundItem as DataRowView;

                if (data != null)
                {
                    txtMaKH.Text = data["Mã khách hàng"].ToString(); // Đúng với DataGridView
                    txtHoten.Text = data["Họ tên"].ToString();
                    txtCMND.Text = data["CMND"].ToString();
                    txtDiachi.Text = data["Địa chỉ"].ToString();
                    txtSDT.Text = data["Số điện thoại"].ToString();
                    txtGhichu.Text = data["Ghi chú"].ToString();

                    // Giới tính
                    bool gioiTinh = Convert.ToBoolean(data["Giới tính"]);
                    rbtnNam.Checked = gioiTinh;
                    rbtnNu.Checked = !gioiTinh;

                    // Ngày sinh (NULL check)
                    if (data["Ngày sinh"] != DBNull.Value)
                    {
                        dNgaysinh.Value = Convert.ToDateTime(data["Ngày sinh"]);
                    }
                    else
                    {
                        dNgaysinh.Value = DateTime.Now; // Giá trị mặc định nếu NULL
                    }

                    btnLuu.Text = "CẬP NHẬT";
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "THÊM")
            {
                if (KiemTraLoiThem())
                {
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
                    btnTimkiem.Enabled = true;
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }
                
            }
            if (btnLuu.Text == "CẬP NHẬT")
            {
                if (KiemTraLoiSua())
                {
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
                    btnTimkiem.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                }
            }
        }


        private bool KiemTraLoiTimKiemTheoHoTen()
        {
            KiemTraHoTen();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtHoten)))
                loiInputs.Add(txtHoten);

            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi tìm kiếm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KiemTraLoiTimKiemTheoCMND()
        {
            KiemTraCMND();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCMND)))
                loiInputs.Add(txtCMND);

            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi tìm kiếm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool KiemTraLoiTimKiemTheoSDT()
        {
            KiemTraSoDienThoai();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtSDT)))
                loiInputs.Add(txtSDT);

            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
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
            gbTimkiem.Enabled = true;
            DisableTextBoxes();
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
         
            btnLuu.Enabled = false;
            if (rbtnHoten.Checked)
            {
                if (KiemTraLoiTimKiemTheoHoTen())
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
                

            }
            else if (rbtnCMND.Checked)
            {
                if (KiemTraLoiTimKiemTheoCMND())
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
                

            }
            else if (rbtnSDT.Checked)
            {
                if (KiemTraLoiTimKiemTheoSDT())
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
        }

        private void rbtnHoten_CheckedChanged(object sender, EventArgs e)
        {
            txtHoten.Enabled = true;
            txtCMND.Enabled = false;
            txtCMND.Text = string.Empty;
            txtSDT.Enabled = false;
            txtSDT.Text = string.Empty;
            errorProvider1.Clear();
            
        }

        private void rbtnCMND_CheckedChanged(object sender, EventArgs e)
        {
            txtCMND.Enabled = true;
            txtSDT.Enabled = false;
            txtSDT.Text = string.Empty;
            txtHoten.Enabled = false;
            txtHoten.Text = string.Empty;
            errorProvider1.Clear();
            
        }

        private void rbtnSDT_CheckedChanged(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            txtCMND.Enabled = false;
            txtCMND.Text = string.Empty;
            txtHoten.Enabled = false;
            txtHoten.Text = string.Empty;
            errorProvider1.Clear();
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ResetTextBoxes();
            DisableTextBoxes();
            gbTimkiem.Enabled = false;

            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
           

            rbtnCMND.Checked = false;
            rbtnHoten.Checked = false;
            rbtnSDT.Checked = false;
            if(btnLuu.Text == "CẬP NHẬT")
            {
                btnLuu.Text = "LƯU";
            }
            if (btnLuu.Text == "THÊM")
            {
                btnLuu.Text = "LƯU";
            }
            hienDanhSachKH();
        }
    }
}
