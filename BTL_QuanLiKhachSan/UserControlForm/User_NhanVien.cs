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
using BTL_QuanLiKhachSan.Object;
using static System.Net.Mime.MediaTypeNames;

namespace BTL_QuanLiKhachSan.Resources
{
    public partial class User_NhanVien : UserControl
    {

        private string connectionString = "";
        private int maNVTrenForm ; 
        public User_NhanVien()
        {
            connectionString = ConfigurationManager.ConnectionStrings["QuanLyKhachSan"].ConnectionString;
            InitializeComponent();
            hienThiDanhSachNhanVienTrongDataGridView(hienThiDanhSachNhanVien());
        }


        private DataTable getListNhanVien()
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("getDSNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon;

        }


        private DataView hienThiDanhSachNhanVien()
        {
            DataTable dbNhanVien = getListNhanVien();
            DataView dataView = dbNhanVien.AsDataView();
            return dataView;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void hienThiDanhSachNhanVienTrongDataGridView(DataView dataViewNhanVien)
        {
            tblNhanVienn.Rows.Clear();
            foreach (DataRow item in dataViewNhanVien.Table.Rows)
            {
                bool gioiTinh = bool.Parse(item[3].ToString()) ? true : false;
                string gioiTinh2 = gioiTinh ? "Nam" : "Nữ"; 
                tblNhanVienn.Rows.Add(item[0], item[1], item[2], item[7], gioiTinh2 , item[4], item[5] , 
                    item[6], item[8], item[9]);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = taoMoiNhanVien();
            if (nv == null)
            {
                return;
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                themKhachHangVaoCSDL(cnn, nv.HoTen, (DateTime)nv.NgaySinh, nv.ChucVu, nv.DiaChi, nv.GioiTinh, nv.SoDienThoai, nv.Email, nv.Luong, nv.GhiChu);
                hienThiDanhSachNhanVienTrongDataGridView(hienThiDanhSachNhanVien());
                cnn.Close();
            }
        }

        public static void themKhachHangVaoCSDL(SqlConnection connection, string hoTen, DateTime ngaySinh, string chucVu, string diaCHi, int? gioiTinh, string sdt, string email, double? luong ,  string ghiChu)
        {
            using (SqlCommand insertKhachHang = new SqlCommand("addDS_NhanVien", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                insertKhachHang.Parameters.Add("@hoTen", hoTen);
                insertKhachHang.Parameters.Add("@ngaySinh", ngaySinh);
                insertKhachHang.Parameters.Add("@chucVu", chucVu);
                insertKhachHang.Parameters.Add("@diaChi", diaCHi);
                insertKhachHang.Parameters.Add("@gioiTinh", gioiTinh);
                insertKhachHang.Parameters.Add("@sdt", sdt);
                insertKhachHang.Parameters.Add("@email", email);
                insertKhachHang.Parameters.Add("@luong", luong);
                insertKhachHang.Parameters.Add("@ghiChu", ghiChu);
                int soDong = insertKhachHang.ExecuteNonQuery();
                if(soDong == 0)
                {
                    MessageBox.Show("Thêm thất bại !");
                } else
                {
                    MessageBox.Show("Thêm thành công !");
                }
            }
        }

        public NhanVien taoMoiNhanVien()
        {
            // ho ten 
            String hoTen = txtTenNV.Text;
            if (hoTen.Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // xử lí date 
            Boolean check = DateTime.TryParse(dateTimeNgaySinh.Text, out DateTime date2);
            DateTime date1 = new DateTime();
            if (check)
            {
                date1 = date2;
            }
            if (date1 > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại   !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // xu li chuc vu 
            String chucVu = txtChucVu.Text;
            // xu li diaChi 
            String diaChi = "";
            string[] lines = txtDiaChi.Lines;
            foreach (string item in lines)
            {
                diaChi += item + " "; 
            }
            // xử lí giới tính 
            if (radioNam.Checked == false && radioNu.Checked == false)
            {
                MessageBox.Show("Giới tính không được để trống  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            int gioiTinh;
            if (radioNu.Checked)
            {
                gioiTinh = 0;
            }
            else
            {
                gioiTinh = 1;
            }
            // xử lí sdt 
            String sdt = "";
            Boolean checkSDT = KiemTraSoDienThoai(txtSDT.Text);
            if (checkSDT == true)
            {
                sdt = txtSDT.Text;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // xu li email 
            String email = txtEmail.Text;
            // xu li chuc vu 
            double luong2 = 0; 
                bool kiemTraSoThuc = double.TryParse(txtLuong.Text, out double luong);
            if (kiemTraSoThuc == false)
            {
                MessageBox.Show("Lỗi nhập lương . Nhập lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            } else if(txtLuong.Text.Length >= 10)
            {
                MessageBox.Show("Luơng nhân viên quá lớn . Nhập lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                luong2 = luong;
            }
            // xu li ghi chu 
            String ghiChu = "";
            string[] lines2 = txtGhiChu.Lines;
            foreach (string item in lines2)
            {
                ghiChu += item + " ";
            }
            // tao moi mot nhan vien 
            NhanVien nv = new NhanVien(hoTen, date2, chucVu,diaChi,gioiTinh,sdt,email,luong2,ghiChu);
            return nv; 
        }

        public bool KiemTraSoDienThoai(string soDienThoai)
        {
            return Regex.IsMatch(soDienThoai, @"^\d{10,12}$");
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
        public static void xoaKhachHangKhoiCSDL(SqlConnection connection, int maNV)
        {
            using (SqlCommand insertKhachHang = new SqlCommand("XoaNhanVien", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                insertKhachHang.Parameters.Add("@MaNhanVien", maNV);
                int soDong = insertKhachHang.ExecuteNonQuery();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(tblNhanVienn.CurrentRow.Cells[0].Value.ToString());
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Gọi hàm xử lý xóa tại đây
                    xoaKhachHangKhoiCSDL(cnn, maNV);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                hienThiDanhSachNhanVienTrongDataGridView(hienThiDanhSachNhanVien());
                cnn.Close();
            }
        }

        public void hienThiKhachHang()
        {
            int maNV = int.Parse(tblNhanVienn.CurrentRow.Cells[0].Value.ToString());
            maNVTrenForm = maNV;
            foreach (DataRowView item in hienThiDanhSachNhanVien())
            {
                if (int.Parse(item[0].ToString()).Equals(maNV))
                {
                    txtMaNV.Text = item[0].ToString();
                    txtTenNV.Text = item[1].ToString();
                    dateTimeNgaySinh.Value = DateTime.Parse(item[2].ToString());
                    txtChucVu.Text = item[4].ToString();
                    if (bool.Parse(item[3].ToString()) == false) radioNu.Checked = true;
                    else radioNam.Checked = true;
                    txtSDT.Text = item[5].ToString();
                    txtEmail.Text = item[6].ToString();
                    txtDiaChi.Text = item[7].ToString();
                    txtLuong.Text = item[8].ToString();
                    txtGhiChu.Text = item[9].ToString();
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
                hienThiKhachHang();
        }

        public static void updateKhachHangVaoCSDL(SqlConnection connection,int maNV , string hoTen, DateTime ngaySinh, string chucVu, string diaCHi, int? gioiTinh, string sdt, string email, double? luong, string ghiChu)
        {
            using (SqlCommand insertKhachHang = new SqlCommand("updateDS_NhanVien", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                insertKhachHang.Parameters.Add("@maNhanVien", maNV);
                insertKhachHang.Parameters.Add("@hoTen", hoTen);
                insertKhachHang.Parameters.Add("@ngaySinh", ngaySinh);
                insertKhachHang.Parameters.Add("@chucVu", chucVu);
                insertKhachHang.Parameters.Add("@diaChi", diaCHi);
                insertKhachHang.Parameters.Add("@gioiTinh", gioiTinh);
                insertKhachHang.Parameters.Add("@sdt", sdt);
                insertKhachHang.Parameters.Add("@email", email);
                insertKhachHang.Parameters.Add("@luong", luong);
                insertKhachHang.Parameters.Add("@ghiChu", ghiChu);
                int soDong = insertKhachHang.ExecuteNonQuery();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNVSua = int.Parse(tblNhanVienn.CurrentRow.Cells[0].Value.ToString());
            if (maNVSua != maNVTrenForm)
            {
                MessageBox.Show("Nhân viên cần cập nhật thông tin không khớp mã nhân viên trên form !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NhanVien nv = taoMoiNhanVien();
            if (nv == null)
            {
                return;
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                updateKhachHangVaoCSDL(cnn, maNVTrenForm, nv.HoTen, (DateTime)nv.NgaySinh, nv.ChucVu, nv.DiaChi, nv.GioiTinh, nv.SoDienThoai, nv.Email, nv.Luong, nv.GhiChu);
                hienThiDanhSachNhanVienTrongDataGridView(hienThiDanhSachNhanVien());
                cnn.Close();
            }
        }

        public DataView timKiemKhachHangTrongCSDL(SqlConnection connection,  string hoTen, DateTime ngaySinh, string chucVu, string diaCHi, int? gioiTinh, string sdt, string email, double? luong, string ghiChu)
        {
            DataTable nhanVien = new DataTable();
            using (SqlCommand insertKhachHang = new SqlCommand("searchDS_NhanVien", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                // Thêm tham số tìm kiếm
                insertKhachHang.Parameters.AddWithValue("@hoTen", (object)hoTen ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@chucVu", (object)chucVu ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@diaChi", (object)diaCHi ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@gioiTinh", (object)gioiTinh ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@sdt", (object)sdt ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@email", (object)email ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@luong", (object)luong ?? DBNull.Value);
                insertKhachHang.Parameters.AddWithValue("@ghiChu", (object)ghiChu ?? DBNull.Value);
                using (SqlDataAdapter adapter = new SqlDataAdapter(insertKhachHang))
                {

                    adapter.Fill(nhanVien);
                }
            }
            return nhanVien.AsDataView();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // ho ten 
            string hoTen = string.IsNullOrWhiteSpace(txtTenNV.Text) ? null : txtTenNV.Text;
            // xử lí date 
            DateTime date = DateTime.Parse(dateTimeNgaySinh.Text);
            // xu li chuc vu 
            string chucVu = string.IsNullOrWhiteSpace(txtChucVu.Text) ? null : txtChucVu.Text;
            // xu li diaChi 
            string diaChi = txtDiaChi.Text != "" ? (string.Join(" ", txtDiaChi.Lines).TrimEnd() + " ").TrimEnd() : null;
            // xử lí giới tính 
            int? gioiTinh = null ;
            if (radioNam.Checked)
            {
                gioiTinh = 1;
            } else if (radioNu.Checked)
            {
                gioiTinh = 0;
            }
            // xử lí sdt 
            string sdt = "";
            if (txtSDT.Text != "")
            {
                Boolean checkSDT = KiemTraSoDienThoai(txtSDT.Text);
                if (checkSDT == true)
                {
                    sdt = txtSDT.Text;
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                sdt = null;
            }
            // xu li email 
            String email = txtEmail.Text;
            // xu li chuc vu 
            double? luong2 ;
            if(txtLuong.Text != "")
            {
                bool kiemTraSoThuc = double.TryParse(txtLuong.Text, out double luong);
                if (kiemTraSoThuc == false)
                {
                    MessageBox.Show("Lỗi nhập lương . Nhập lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtLuong.Text.Length >= 10)
                {
                    MessageBox.Show("Luơng nhân viên quá lớn . Nhập lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    luong2 = luong;
                }
            } else
            {
                 luong2 = null;
            }
            // xu li ghi chu 
            string ghiChu = txtGhiChu.Text != "" ? (string.Join(" ", txtGhiChu.Lines).TrimEnd()).TrimEnd() : null;
            NhanVien nv = new NhanVien(hoTen,date,chucVu,diaChi,gioiTinh,sdt,email,luong2,ghiChu);
            if (nv == null)
            {
                MessageBox.Show("error");
                return;
            }
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                DataView nhanVien = timKiemKhachHangTrongCSDL(cnn, nv.HoTen, (DateTime)nv.NgaySinh, nv.ChucVu, nv.DiaChi, nv.GioiTinh, nv.SoDienThoai, nv.Email, nv.Luong, nv.GhiChu);
                hienThiDanhSachNhanVienTrongDataGridView(nhanVien);
                cnn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
            
}
