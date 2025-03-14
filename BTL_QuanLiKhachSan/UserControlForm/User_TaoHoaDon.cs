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
    public partial class User_TaoHoaDon : UserControl
    {
        private int maDK;
        private double tongTien = 0; 
        private string connectionString = "";
        public User_TaoHoaDon()
        {
            connectionString = ConfigurationManager.ConnectionStrings["QuanLyKhachSan"].ConnectionString;
            InitializeComponent();
            //hoa don 
            cbbMaDangKi.DataSource = getDSDangKy();
            cbbMaDangKi.ValueMember = "MaDangKy";
            cbbMaDangKi.DisplayMember = "MaDangKy";
            // dich vu 
            cbbTenDichVu.DataSource = getListDichVu();
            cbbTenDichVu.ValueMember = "MaDichVu";
            cbbTenDichVu.DisplayMember = "TenDichVu";
            maDK = int.Parse(cbbMaDangKi.SelectedValue.ToString());
            loadDuLieuLenFormChiTietHD(maDK);
            // format datetime 
            dateNgayLapHD.CustomFormat = "dd/MM/yyyy HH:mm";
            dateNgayNhanThucTe.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private DataView getDSDangKy()
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("getDS_DangKi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getMaDangKyBiId(int maDK)
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("get_MaDangKiByID", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDK", maDK);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getMaPById(int maP)
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("get_MaPByID", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maP", maP);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getMaNhanVienById(int maNV)
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("get_MaNVByID", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNV", maNV);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getMaKHById(int maKH)
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("get_MaKHByID", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKH", maKH);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getListHoaDon()
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("getDS_HD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }
        private DataView getListDichVu()
        {
            DataTable dbHoaDon = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("getDS_DichVu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {

                    adapter.Fill(dbHoaDon);
                }
            }
            return dbHoaDon.AsDataView();

        }

        public static void themHoaDon(SqlConnection connection, int maDK , DateTime ngayLapHD ,DateTime ngayNhanP )
        {
            using (SqlCommand insertKhachHang = new SqlCommand("sp_InsertHoaDon", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                insertKhachHang.Parameters.Add("@MaDangKy", maDK);
                insertKhachHang.Parameters.Add("@NgayLapHoaDon", ngayLapHD);
                insertKhachHang.Parameters.Add("@NgayThucTeNhan", ngayNhanP);
                int soDong = insertKhachHang.ExecuteNonQuery();
                if (soDong > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công ");
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thành công ");
                }
            }
        }
        public static void themDichVuVaoCTHD(SqlConnection connection, string hoTen, DateTime ngaySinh, string chucVu, string diaCHi, int? gioiTinh, string sdt, string email, double? luong, string ghiChu)
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
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtThemDV_Click(object sender, EventArgs e)
        {   
            int id = int.Parse(cbbTenDichVu.SelectedValue.ToString());

            string tenDV = cbbTenDichVu.Text;
            DateTime ngaySD = dateNgayDungDV.Value; 
            int soLuong = int.Parse(txtSoLuong.Text);
            double donGia = 0;
            double thanhTien = 0;
            foreach (DataRowView item in getListDichVu())
            {
                if (int.Parse(item[0].ToString()) == (id))
                {
                    donGia = double.Parse(item[2].ToString());
                    thanhTien = soLuong * donGia;
 
                    break;
                }
            }
            bool check = false;
            if (tblChiTietDV.Rows.Count == 0  )
            {
                tblChiTietDV.Rows.Add(id, tenDV, ngaySD, soLuong, donGia, thanhTien);
            } else 
            {
                foreach (DataGridViewRow item in tblChiTietDV.Rows)
                {
                    if (item.Cells[0].Value != null && item.Cells[0].Value.ToString() == id.ToString())
                    {
                        check = true; break;
                    }
                }
            }
            if(check == false)
            {
                tblChiTietDV.Rows.Add(id, tenDV, ngaySD, soLuong, donGia, thanhTien);
            }
            
        }
        public double tinhTongTienDV() // tinh tong tien dv 
        {
            tongTien = 0;
            // Kiểm tra nếu tblChiTietDV không bị null
            if (tblChiTietDV != null && tblChiTietDV.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in tblChiTietDV.Rows)
                {
                    // Kiểm tra cột có tồn tại và giá trị không bị null
                    if (item.Cells["TongTienn"] != null && item.Cells["TongTienn"].Value != null)
                    {
                        if (double.TryParse(item.Cells["TongTienn"].Value.ToString(), out double giaTri))
                        {
                            tongTien += giaTri;
                        }
                    }
                }
            }

            return tongTien;
        }
        public int soNgayThue()
        {
            int ngaythue = 0;
            if (dateNgayLapHD.Value != null && dateNgayNhanThucTe.Value != null) // xu li so ngay thue 
            {
                DateTime ngayLapHD = dateNgayLapHD.Value;
                DateTime ngayNhanThucTe = dateNgayNhanThucTe.Value;

                int soNgay = (ngayLapHD - ngayNhanThucTe).Days;
                int soNgayThue = soNgay > 0 ? soNgay : 1; // Nếu số ngày <= 0 thì vẫn tính 1 ngày
                return soNgayThue;
            }
            return ngaythue; 
        }
        // Tính phí check-in sớm
        public double TinhPhiCheckInSom(double giaPhong)
        {
            if (dateNgayNhanThucTe.Value != null)
            {
                int gioNhan = dateNgayNhanThucTe.Value.Hour;
                if (gioNhan >= 5 && gioNhan < 9)
                    return giaPhong * 0.5; // Check-in 5h-9h: 50%
                else if (gioNhan >= 9 && gioNhan < 14)
                    return giaPhong * 0.3; // Check-in 9h-14h: 30%
            }
            return 0;
        }
        public double TinhPhiCheckOutMuon(double giaPhong , DateTime ngayTraDuKien)
        {
            double phiMuon =  0;    
            if (dateNgayLapHD.Value != null)
            {
                int gioLap = dateNgayLapHD.Value.Hour;
                int SoNgayDu = (dateNgayLapHD.Value - ngayTraDuKien).Days;
                if(SoNgayDu < 0)
                {
                    if (gioLap >= 13 && gioLap < 15)
                        return giaPhong * 0.3; // Check-out 13h-15h: 30%
                    else if (gioLap >= 15 && gioLap < 18)
                        return giaPhong * 0.5; // Check-out 15h-18h: 50%
                    else if (gioLap >= 18)
                        return giaPhong; // Check-out sau 18h: 100%
                } else
                {
                    if (gioLap >= 13 && gioLap < 15) phiMuon = giaPhong * 0.3;
                    if (gioLap >= 15 && gioLap < 18) phiMuon = giaPhong * 0.5;
                    if (gioLap >= 18) phiMuon = giaPhong;
                    return (SoNgayDu * giaPhong) + phiMuon;
                }
            }
            return 0;
        }
        private void txtXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblChiTietDV.CurrentRow == null)
                {
                    return;
                }
                else
                {
                    DataGridViewRow row = tblChiTietDV.CurrentRow;
                    tblChiTietDV.Rows.Remove(row);
                }
            }
            catch (InvalidOperationException ex) { 
                return ;
            }
        }
        private void loadDuLieuLenFormChiTietHD(int maDK)
        {
            lblNgayLapHD.Text = dateNgayLapHD.Value.ToString(); // ngay lap hd
            lblPhiDichVu.Text = tinhTongTienDV().ToString() + " vnd"; // phi dich vu 
            DataView dangKi = getMaDangKyBiId(maDK);
            lblNgayDangKi.Text = dangKi[0]["NgayDangKy"].ToString(); // ngay dang ki 
            lblNgayNhanP.Text = dangKi[0]["NgayNhanPhong"].ToString(); // ngay nhan phong
            lblNgayNhanPThucTe.Text = dateNgayNhanThucTe.Value.ToString();  // ngay nhan phong thuc te
            lblNgayTraP.Text = dangKi[0]["NgayTraPhong"].ToString();  // ngay tra phong du kien
            int maP = int.Parse(dangKi[0]["MaPhong"].ToString());
            int maNV = int.Parse(dangKi[0]["MaNV"].ToString());
            int maKH = int.Parse(dangKi[0]["MaKhach"].ToString());
            DataView phong = getMaPById(maP);
            lblTenP.Text = phong[0]["SoPhong"].ToString(); // ten phong
            lblGiaP.Text = (phong[0]["DonGia"].ToString()) + " vnd"; // gia phong 
            DataView nhanVien = getMaNhanVienById(maNV);
            lblTenNV.Text = nhanVien[0]["HoTen"].ToString(); // ten nhan vien 
            DataView khachHang = getMaKHById(maKH);
            lblTenKH.Text = khachHang[0]["HoTen"].ToString(); // ten khach hang
            lblSoNgayThue.Text = soNgayThue().ToString(); // tinh so ngay thue 
            lblPhiCheckIn.Text = TinhPhiCheckInSom(double.Parse(phong[0]["DonGia"].ToString())).ToString() + " vnd"; // phi check in 
            lblPhiCheckOut.Text = TinhPhiCheckOutMuon(double.Parse(phong[0]["DonGia"].ToString()), // phi check ou
                DateTime.Parse(dangKi[0]["NgayTraPhong"].ToString())).ToString() + " vnd";
            //lblThanhT.Text = (int.Parse((phong[0]["DonGia"].ToString())) * soNgayThue()).ToString();
            bool giaP = double.TryParse((phong[0]["DonGia"].ToString()), out double giaP2);
            double thanhTien = giaP2 * soNgayThue(); 
            lblThanhT.Text = (giaP2 * soNgayThue()).ToString() + " vnd";
            lblTongTien.Text = (thanhTien + TinhPhiCheckInSom(double.Parse(phong[0]["DonGia"].ToString()))
                + TinhPhiCheckOutMuon(double.Parse(phong[0]["DonGia"].ToString()), // phi check ou
                DateTime.Parse(dangKi[0]["NgayTraPhong"].ToString())) + tinhTongTienDV()).ToString() + " vnd";
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaDangKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maDK = int.Parse(cbbMaDangKi.SelectedValue.ToString());
            loadDuLieuLenFormChiTietHD(maDK);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                int maDK = int.Parse(cbbMaDangKi.SelectedValue.ToString());
                DateTime ngayLapHD = dateNgayLapHD.Value;
                DateTime ngayNhanP = dateNgayNhanThucTe.Value;
                themHoaDon(cnn, maDK,ngayLapHD,ngayNhanP);
                cnn.Close();
            }
        }

        private void lblNgayLapHD_Click(object sender, EventArgs e)
        {
        }

        private void dateNgayLapHD_ValueChanged(object sender, EventArgs e)
        {
            lblNgayLapHD.Text = dateNgayLapHD.Value.ToString("dd/MM/yyyy");
        }

        private void lblPhiDichVu_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayNhanThucTe_ValueChanged(object sender, EventArgs e)
        {
            lblNgayNhanPThucTe.Text = dateNgayNhanThucTe.Value.ToString("dd/MM/yyyy");
        
        }

        private void tblChiTietDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }
    }   
}
