using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cinema_Management
{
    public partial class PhanDangKy : Form
    {
        public PhanDangKy()
        {
            InitializeComponent();
        }

        public static string ToSha256(string input) // Hàm được viết bởi bạn Hoàng Nhật Huy
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        string connectionString = "Server=.;Database=USERS;Integrated Security=True;";
        private void NutDangKy_Click(object sender, EventArgs e)
        {
            string Name = HoTen.Text.Trim();
            string TenDangNhap = Username.Text.Trim();
            string SDT = SoDienThoai.Text.Trim();
            string E_mail = Email.Text.Trim();
            string MatKhauGoc = MatKhau.Text;
            string XacNhanMK = XacNhanMatKhau.Text;
            string Area = KhuVuc.SelectedItem?.ToString();
            DateTime NgaySinh = NgayThangNamSinh.Value.Date;

            if (TenDangNhap == "" || Name == "" || SDT == "" || E_mail == "" || MatKhauGoc == "" || XacNhanMK == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(Name, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                MessageBox.Show("Họ tên không hợp lệ (chỉ cho phép chữ).");
                return;
            }

            if (!Regex.IsMatch(SDT, @"^(0\d{9}|\+84\d{9})$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(E_mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(MatKhauGoc, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự, có chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }

            if (MatKhauGoc != XacNhanMK)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
                return;
            }
            if (NgaySinh > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ (Không được là ngày trong tương lai).");
                return;
            }

            try
            {

                string MatKhauDaHash = ToSha256(MatKhauGoc);
            } catch {}// dùng thuật toán SHA256 để mã hóa mật khẩu
            }

                // Thục thi lệnh INSERT INTO vào bảng UserClient
       /*         string sqlInsert = @"
            INSERT INTO UserClient (Username, HoTen, NgaySinh, SDT, Email, KhuVuc, MaHashCuaMatKhau) 
            VALUES (@Username, @HoTen, @NgaySinh, @SDT, @Email, @KhuVuc, @MaHashCuaMatKhau)";

            
            } */

   /*             using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Truyền tham số
                        command.Parameters.AddWithValue("@Username", TenDangNhap);
                        command.Parameters.AddWithValue("@HoTen", Name);

                        
                        command.Parameters.AddWithValue("@NgaySinh", NgaySinh);

                        command.Parameters.AddWithValue("@SDT", SDT);
                        command.Parameters.AddWithValue("@Email", E_mail);
                        command.Parameters.AddWithValue("@KhuVuc", Area ?? (object)DBNull.Value); // Xử lý nếu ComboBox trống

                        // Truyền MÃ HASH vào database
                        command.Parameters.AddWithValue("@MaHashCuaMatKhau", MatKhauDaHash);


                        int rowsAffected = command.ExecuteNonQuery(); // Execute lệnh SQL

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công");

                            string finalArea = Area ?? "Chưa có";

                            UserInfo NewUser = new UserInfo  // Khởi tạo đối tượng NewUser thuộc lớp UserInfo để thông tin người dùng lưu vào đối tượng NewUser
                            {
                                Username = TenDangNhap,
                                HoTen = Name,
                                NgaySinh = NgaySinh,
                                SDT = SDT, 
                                Email = E_mail,
                                KhuVuc = finalArea
                            };
                            GiaoDienSauKhiDaDangNhapHoacDangKyXong GiaoDien = new GiaoDienSauKhiDaDangNhapHoacDangKyXong(NewUser); // Constructor dùng để khởi tạo form có tham số là đối tượng NewUser
                            this.Hide(); 
                            GiaoDien.Show();
                            GiaoDien.FormClosed += (s, args) => this.Close(); // đóng form cũ khi form mới tắt
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Lỗi 2627 là lỗi trùng lập Username
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi Database");
                }
                else
                {
                    MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi");
            }

                */
        


        private void NutDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangNhap DangNhap = new PhanDangNhap();
            this.Hide();
            DangNhap.Show();
            DangNhap.FormClosed += (s, args) => this.Close();
        }

        private void NgayThangNam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class UserInfo
    {
        public string Username { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string KhuVuc { get; set; }
    }
}

