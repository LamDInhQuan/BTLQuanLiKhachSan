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
    public partial class User_QLyHoaDon : UserControl
    {
        private string connectionString = "";
        public User_QLyHoaDon()
        {
            connectionString = ConfigurationManager.ConnectionStrings["QuanLyKhachSan"].ConnectionString;
            InitializeComponent();
            hienThiDanhSachHoaDonTrongDataGridView(getListHoaDon());
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
        private void hienThiDanhSachHoaDonTrongDataGridView(DataView dataViewHoaDon)
        {
            tblHoaDon.Rows.Clear();
            foreach (DataRow item in dataViewHoaDon.Table.Rows)
            {
                tblHoaDon.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5],
                    item[6], item[7], item[8], item[9], item[10], item[11]);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        public static void xoaHoaDonKhoiCSDL(SqlConnection connection, int maHD)
        {
            using (SqlCommand insertKhachHang = new SqlCommand("XoaHoaDon", connection))
            {
                insertKhachHang.CommandType = CommandType.StoredProcedure;
                insertKhachHang.Parameters.Add("@MaHD", maHD);
                int soDong = insertKhachHang.ExecuteNonQuery();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(tblHoaDon.CurrentRow.Cells[0].Value.ToString());
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
                    xoaHoaDonKhoiCSDL(cnn, maHD);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                hienThiDanhSachHoaDonTrongDataGridView(getListHoaDon());
                cnn.Close();
            }
        }
    }
}
