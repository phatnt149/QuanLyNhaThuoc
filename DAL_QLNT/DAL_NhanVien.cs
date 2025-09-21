using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Security.Cryptography;
using DTO_QLNT;
using System.Collections;
using System.Windows.Forms;
namespace DAL_QLNT
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable getNhanVien(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtNhanvien = new DataTable();
            da.Fill(dtNhanvien);
            return dtNhanvien;
        }

        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", _conn);
            DataTable dtNhanvien = new DataTable();
            da.Fill(dtNhanvien);
            return dtNhanvien;
        }

        public DataTable GetSimple()
        {
            string sql = "SELECT userName, hoTen FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = @"INSERT INTO NHANVIEN
               (userName, passWord, hoTen, ngaySinh, gioiTinh, diaChi, hinhAnh, chucVu)
               VALUES (@UserName, @PassWord, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @HinhAnh, @ChucVu)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", nv.UserName);
                    cmd.Parameters.AddWithValue("@PassWord", nv.PassWord);
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                    cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);

                    if (nv.HinhAnh != null)
                        cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = nv.HinhAnh;
                    else
                        cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public bool suaNhanVien(DTO_NhanVien nv, int n)
        {
            if (n == 1)
            {
                try
                {
                    // Ket noi
                    _conn.Open();
                    string SQL = @"UPDATE NHANVIEN
               SET passWord = @PassWord,
                   hoTen = @HoTen,
                   ngaySinh = @NgaySinh,
                   gioiTinh = @GioiTinh,
                   diaChi = @DiaChi,
                   hinhAnh = @HinhAnh,
                   chucVu = @ChucVu
               WHERE userName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", nv.UserName);
                        cmd.Parameters.AddWithValue("@PassWord", nv.PassWord);
                        cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                        cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);

                        if (nv.HinhAnh != null)
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = nv.HinhAnh;
                        else
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;

                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                    }


                }
                catch (Exception e)
                {
                }
                finally
                {
                    // Dong ket noi
                    _conn.Close();
                }
                return false;
            }
            else if (n == 2)
            {
                try
                {
                    // Ket noi
                    _conn.Open();
                    string SQL = @"UPDATE NHANVIEN
               SET 
                   hoTen = @HoTen,
                   ngaySinh = @NgaySinh,
                   gioiTinh = @GioiTinh,
                   diaChi = @DiaChi,
                   hinhAnh = @HinhAnh,
                   chucVu = @ChucVu
               WHERE userName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", nv.UserName);
                        cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                        cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);

                        if (nv.HinhAnh != null)
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = nv.HinhAnh;
                        else
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;

                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                    }


                }
                catch (Exception e)
                {
                }
                finally
                {
                    // Dong ket noi
                    _conn.Close();
                }
                return false;
            }
            else
            {
                try
                {
                    // Ket noi
                    _conn.Open();
                    string SQL = @"UPDATE NHANVIEN
               SET
                   hoTen = @HoTen,
                   ngaySinh = @NgaySinh,
                   gioiTinh = @GioiTinh,
                   diaChi = @DiaChi,
                   hinhAnh = @HinhAnh
               WHERE userName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", nv.UserName);
                        cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);

                        if (nv.HinhAnh != null)
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = nv.HinhAnh;
                        else
                            cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;

                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                    }


                }
                catch (Exception e)
                {
                }
                finally
                {
                    // Dong ket noi
                    _conn.Close();
                }
                return false;
            }
        }

        public bool xoaNhanVien(string userName)
        {
            try
            {
                _conn.Open();
                string SQL = "DELETE FROM NHANVIEN WHERE userName = @userName";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@userName", userName);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable timNhanVienTheoUserName(string userName)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                string SQL = "SELECT * FROM NHANVIEN WHERE userName LIKE @userName";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@userName", "%" + userName + "%"); // tìm kiếm chứa chuỗi

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Hàm đăng nhập, trả về đối tượng DTO_NhanVien nếu thành công, null nếu thất bại
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Các lỗi liên quan đến truy vấn kết nối cơ sở dữ liệu</exception>
        public DTO_NhanVien DangNhap(string username, string password)
        {
            try
            {
                _conn.Open();
                string query = "SELECT * FROM NhanVien WHERE userName = @username AND passWord = @password";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lấy thông tin nhân viên từ DB
                            DTO_NhanVien nv = new DTO_NhanVien
                            {
                                UserName = reader["userName"].ToString(),
                                PassWord = reader["passWord"].ToString(),
                                HoTen = reader["hoTen"].ToString(),
                                NgaySinh = reader["ngaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["ngaySinh"]) : DateTime.MinValue,
                                GioiTinh = reader["gioiTinh"].ToString(),
                                DiaChi = reader["diaChi"].ToString(),
                                HinhAnh = reader["hinhAnh"] != DBNull.Value ? (byte[])reader["hinhAnh"] : null,
                                ChucVu = reader["chucVu"].ToString()
                            };
                            return nv;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null; // Không tìm thấy tài khoản, mật khẩu hoặc tài khoản sai
        }

    }
}
