using BTL_QuanLiKhachSan.Report;
using CrystalDecisions.CrystalReports.Engine;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtMadangky.Enabled = false;
            gbTimkiem.Enabled = false;
            DisableTextBoxes();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDanhSachPhong();
            cboMaphong.SelectedIndex = -1;
            LoadDanhSachKhachHang();
            cboMaKH.SelectedIndex = -1;
            LoadDanhSachNhanVien();
            cboMaNV.SelectedIndex = -1;
        }
        private void EnableTextBoxes()
        {
            cboMaphong.Enabled = true;
            cboMaKH.Enabled = true;
            cboMaNV.Enabled = true;
            dNgaydatphong.Enabled = true;
            dNgaynhanphong.Enabled = true;
            dNgaytraphong.Enabled = true;
        }
        private void DisableTextBoxes()
        {
            cboMaphong.Enabled = false;
            cboMaKH.Enabled = false;
            cboMaNV.Enabled = false;
            dNgaydatphong.Enabled = false;
            dNgaynhanphong.Enabled = false;
            dNgaytraphong.Enabled = false;
        }
        private void ResetTextBoxes()
        {
            cboMaKH.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            cboMaphong.SelectedIndex = -1;
            dNgaydatphong.Text = string.Empty;
            dNgaynhanphong.Text = string.Empty;
            dNgaytraphong.Text = string.Empty;
        }
        private void LoadDanhSachPhong()
        {
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                string query = "LoadDSP";
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
                string query = "LoadDSKH";
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
                string query = "LoadDSNV";
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
            cboMaNV.Leave += cboMaNV_Leave;
            cboMaKH.Leave += cboMaKH_Leave;
            cboMaphong.Leave += cboMaphong_Leave;
            dNgaydatphong.Leave += dNgaydatphong_Leave;
            dNgaynhanphong.Leave += dNgaynhanphong_Leave;
            dNgaytraphong.Leave += dNgaytraphong_Leave;
        }
        private void KiemTraPhong()
        {
            if (cboMaphong.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboMaphong.Text))
            {
                errorProvider1.SetError(cboMaphong, "Số phòng không được để trống!");

                return;
            }
            else
            {
                errorProvider1.SetError(cboMaphong, ""); // Xóa lỗi nếu hợp lệ
            }
        }
        private void cboMaphong_Leave(object sender, EventArgs e)
        {
            KiemTraPhong();
        }
        private void KiemTraNhanVien()
        {
            if (cboMaNV.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboMaNV.Text))
            {
                errorProvider1.SetError(cboMaNV, "Nhân viên không được để trống!");

                return;
            }
            else
            {
                errorProvider1.SetError(cboMaNV, ""); // Xóa lỗi nếu hợp lệ
            }
        }
        private void cboMaNV_Leave(object sender, EventArgs e)
        {
            KiemTraNhanVien();
        }
        private void KiemTraKhachHang()
        {
            if (cboMaKH.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboMaKH.Text))
            {
                errorProvider1.SetError(cboMaKH, "Khách hàng không được để trống!");

                return;
            }
            else
            {
                errorProvider1.SetError(cboMaKH, ""); // Xóa lỗi nếu hợp lệ
            }
        }
        private void cboMaKH_Leave(object sender, EventArgs e)
        {
            KiemTraKhachHang();
        }
        private void KiemTraNgayDatPhong()
        {
            DateTime ngayDatPhong = dNgaydatphong.Value.Date;
            DateTime ngayHienTai = DateTime.Now.Date; // Chỉ lấy ngày, bỏ phần giờ phút giây

            if (ngayDatPhong < ngayHienTai)
            {
                errorProvider1.SetError(dNgaydatphong, "Ngày đặt phòng không được nhỏ hơn ngày hiện tại!");
                return;
            }
            else
            {
                errorProvider1.SetError(dNgaydatphong, "");
            }
        }
        private void dNgaydatphong_Leave(object sender, EventArgs e)
        {
            KiemTraNgayDatPhong();
        }
        private void KiemTraNgayNhanPhong()
        {
            DateTime ngayDatPhong = dNgaydatphong.Value.Date;
            DateTime ngayNhanPhong = dNgaynhanphong.Value.Date;
            if (ngayNhanPhong < ngayDatPhong)
            {
                errorProvider1.SetError(dNgaynhanphong, "Ngày nhận phòng phải sau hoặc bằng ngày đặt phòng!");
                return;
            }
            else
            {
                errorProvider1.SetError(dNgaynhanphong, "");
            }

        }
        private void dNgaynhanphong_Leave(object sender, EventArgs e)
        {
            KiemTraNgayNhanPhong();
        }
        private void KiemTraNgayTraPhong()
        {
            DateTime ngayNhanPhong = dNgaynhanphong.Value.Date;
            DateTime ngayTraPhong = dNgaytraphong.Value.Date;

            if (ngayTraPhong <= ngayNhanPhong)
            {
                errorProvider1.SetError(dNgaytraphong, "Ngày trả phòng phải sau ngày nhận phòng!");
                return;
            }
            else
            {
                errorProvider1.SetError(dNgaytraphong, "");
            }
        }
        private void dNgaytraphong_Leave(object sender, EventArgs e)
        {
            KiemTraNgayTraPhong();
        }
        private bool KiemTraLoi()
        {
            KiemTraKhachHang();
            KiemTraNhanVien();
            KiemTraPhong();
            KiemTraNgayDatPhong();
            KiemTraNgayNhanPhong();
            KiemTraNgayTraPhong();

            // Danh sách các ô nhập có lỗi
            List<Control> loiInputs = new List<Control>();

            if (!string.IsNullOrEmpty(errorProvider1.GetError(cboMaKH)))
                loiInputs.Add(cboMaKH);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(cboMaNV)))
                loiInputs.Add(cboMaNV);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(cboMaphong)))
                loiInputs.Add(cboMaphong);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(dNgaydatphong)))
                loiInputs.Add(dNgaydatphong);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(dNgaynhanphong)))
                loiInputs.Add(dNgaynhanphong);
            if (!string.IsNullOrEmpty(errorProvider1.GetError(dNgaytraphong)))
                loiInputs.Add(dNgaytraphong);
            // Nếu có lỗi, focus vào ô nhập đầu tiên bị lỗi
            if (loiInputs.Count > 0)
            {
                loiInputs[0].Focus();
                MessageBox.Show("Vui lòng kiểm tra lại các lỗi trước khi thêm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void dgvDangky_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDangky.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDangky.SelectedRows[0];
                var dangKy = selectedRow.DataBoundItem as DataRowView; 

                if (dangKy != null)
                {
                    txtMadangky.Text = dangKy["Mã đặt phòng"].ToString();
                    cboMaphong.SelectedValue = dangKy["Mã phòng"].ToString();
                    cboMaKH.SelectedValue = dangKy["Mã khách hàng"].ToString();
                    cboMaNV.SelectedValue = dangKy["Mã nhân viên"].ToString();
                    dNgaydatphong.Value = Convert.ToDateTime(dangKy["Ngày đặt phòng"]);
                    dNgaynhanphong.Value = Convert.ToDateTime(dangKy["Ngày nhận phòng"]);
                    dNgaytraphong.Value = Convert.ToDateTime(dangKy["Ngày trả phòng"]);
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableTextBoxes();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnNhan.Enabled = false;
            btnHuyDP.Enabled = false;
            btnTimkiem.Enabled = false;
            btnDat.Enabled = false;
            btnLuu.Text = "ĐẶT";
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (btnLuu.Text == "ĐẶT")
            {
                if (KiemTraLoi())
                {
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
                    btnHuyDP.Enabled = true;
                    btnTimkiem.Enabled = true;
                    btnDat.Enabled = true;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }
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
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            gbTimkiem.Enabled = true;
            SearchCustomers(txtNdTimkiem.Text.Trim());
        }
        private void SearchCustomers(string keyword)
        {
            listTimkiem.Items.Clear();
            
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionStrings))
            {
                conn.Open();
                string procName = "sp_DangkySearch";
                using (SqlCommand cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                   
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            string result = $"{reader["Mã đặt phòng"]} : {reader["Số phòng"]} - {reader["Tên khách hàng"]} - {reader["Tên nhân viên"]} - {reader["Ngày đăng ký"]} - {reader["Ngày nhận phòng"]} - {reader["Ngày trả phòng"]}";

                            listTimkiem.Items.Add(result);
                        }
                    }
                }
            }
        }
        private void LoadInvoices(int customerId)
        {
            string procName = "spDSTK";
            using (SqlConnection cnn = new SqlConnection(connectionStrings))
            {
                using (SqlCommand cmd = new SqlCommand(procName, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@madangky", customerId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDangky.DataSource = dt;
                }
            }
        }

        private void listTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTimkiem.SelectedItem != null)
            {
                string selectedText = listTimkiem.SelectedItem.ToString();
                int customerId = int.Parse(selectedText.Split(':')[0]);
                LoadInvoices(customerId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionStrings))
                {
                    cnn.Open();

                    string query = "sp_GetHoaDonByDateRange";
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", dateTimePicker3.Value);
                        cmd.Parameters.AddWithValue("@EndDate", dateTimePicker4.Value);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            da.Fill(table);
                            DangKy rpt = new DangKy();
                            //rptDatPhong rpt = new rptDatPhong();
                            rpt.SetDataSource(table);
                            FormInBaoCao form = new FormInBaoCao();
                            form.crv1.ReportSource = rpt;
                            form.ShowDialog();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDangky_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            ResetTextBoxes();
            DisableTextBoxes();
            gbTimkiem.Enabled = false;

            btnTimkiem.Enabled = true;
            btnDat.Enabled = true;
            btnNhan.Enabled = true;
            btnHuyDP.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
           
            if (btnLuu.Text == "ĐẶT")
            {
                btnLuu.Text = "LƯU";
            }
            hienDanhSachDangKy();
        }
    }
}
