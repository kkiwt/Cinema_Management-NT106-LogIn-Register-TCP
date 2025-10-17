using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace Cinema_Management
{
    public partial class PhanDangNhap : Form
    {
        public PhanDangNhap()
        {
            InitializeComponent();
        }

        private UserInfo LayVaTaoThongTinUser(string Username)
        {
            UserInfo User = null;
            // truy vấn thông tin từ database thông qua Username nếu trùng với username mà người dùng nhập vào
            string sqlSelectUser = @"
        SELECT HoTen, NgaySinh, SDT, Email, KhuVuc 
        FROM UserClient 
        WHERE Username = @Username";

            // Kết nối với database
            string ConnectionString = "Server=.;Database=USERS;Integrated Security=True;";

            try
            {
                /*             using (SqlConnection Connection = new SqlConnection(ConnectionString))
                             {
                                 Connection.Open();
                                 using (SqlCommand command = new SqlCommand(sqlSelectUser, Connection))
                                 {
                                     command.Parameters.AddWithValue("@Username", Username);

                                     using (SqlDataReader reader = command.ExecuteReader())
                                     {
                                         if (reader.Read())
                                         {
                                             User = new UserInfo();
                                             User.Username = Username;
                                             User.HoTen = reader["HoTen"].ToString();
                                             User.SDT = reader["SDT"].ToString();
                                             User.Email = reader["Email"].ToString();


                                             User.KhuVuc = reader["KhuVuc"] == DBNull.Value ? "" : reader["KhuVuc"].ToString();


                                             if (reader["NgaySinh"] != DBNull.Value)
                                             {
                                                 User.NgaySinh = (DateTime)reader["NgaySinh"];
                                             }
                                             else
                                             {
                                                 User.NgaySinh = DateTime.MinValue; 
                                             }
                                         }
                                     }
                                 }
                             }
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show($"Lỗi truy vấn thông tin người dùng: {ex.Message}", "Lỗi");
                         }
                */

            }
            catch { }
            return User;
        }
        
        public static string ToSha256(string input) // hàm thuật toán SHA-256
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private const string connectionString = "Server=.;Database=USERS;Integrated Security=True;"; // Kết nối với database
        private void button1_Click(object sender, EventArgs e)
        {



            string Username = TenDangNhap.Text.Trim(); 
            string MatKhauNhap = MatKhau.Text; 

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(MatKhauNhap))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Lỗi nhập liệu");
                return;
            }

            // Tên cột phải khớp: MaHashCuaMatKhau
            string sqlSelectHash = "SELECT MaHashCuaMatKhau FROM UserClient WHERE Username = @Ten";
            // Chọn mã Hash của Mật khẩu từ bảng UserClient nếu Username trùng  với Ten , là username người dùng nhập vào

            string matKhauHashTrongDB = null;

     /*       try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlSelectHash, connection))
                    {

                        command.Parameters.AddWithValue("@Ten", Username);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            matKhauHashTrongDB = result.ToString();
                        }

                    }
                }

                if (matKhauHashTrongDB == null)
                {
                    // Không tìm thấy tên đăng nhập, hoặc tên đăng nhập không tồn tại
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng.", "Lỗi Đăng nhập");
                    return;
                }
                // Băm mật khẩu người dùng nhập vào bằng SHA-256
                string hashMatKhauNhap = ToSha256(MatKhauNhap);

                // So sánh chuỗi hash vừa tính toán với chuỗi hash đã lấy từ DB
                if (hashMatKhauNhap == matKhauHashTrongDB)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thành công");

                    UserInfo CurrentUser = LayVaTaoThongTinUser(Username);

                    if (CurrentUser == null)
                    {
                        MessageBox.Show("Lỗi hệ thống: Không lấy được thông tin hồ sơ người dùng.", "Lỗi");
                        return;
                    }

                    GiaoDienSauKhiDaDangNhapHoacDangKyXong GiaoDien = new GiaoDienSauKhiDaDangNhapHoacDangKyXong(CurrentUser);
                    this.Hide();
                    GiaoDien.Show();
                    GiaoDien.FormClosed += (s, args) => this.Close(); 
                }
                else
                {
                    // Mật khẩu sai
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng.", "Lỗi Đăng nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc thao tác: {ex.Message}", "Lỗi");
            }






            */







        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangKy DangKy = new PhanDangKy();
            this.Hide();
            DangKy.Show();
            DangKy.FormClosed += (s, args) => this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PhanDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
