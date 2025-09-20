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
    public class DAL_NCC : DBConnect
    {
        public DataTable getNCC(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtNhaCC = new DataTable();
            da.Fill(dtNhaCC);
            return dtNhaCC;
        }

        public DataTable getNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", _conn);
            DataTable dtNhaCC = new DataTable();
            da.Fill(dtNhaCC);
            return dtNhaCC;
        }

        public bool themNhaCC(DTO_NCC ncc)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = @"INSERT INTO NHACUNGCAP
               (tenNcc, loaiNcc, moTa)
               VALUES (@TenNcc, @LoaiNcc, @MoTa)";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenNcc", ncc.TenNcc);
                    cmd.Parameters.AddWithValue("@LoaiNcc", ncc.LoaiNcc);
                    cmd.Parameters.AddWithValue("@MoTa", ncc.MoTa);

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

        public bool suaNhaCC(DTO_NCC ncc)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = @"UPDATE NHACUNGCAP
               SET tenNcc = @TenNcc,
                   loaiNcc = @LoaiNcc,
                   moTa = @MoTa
               WHERE maNcc = @MaNcc";

                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenNcc", ncc.TenNcc);
                    cmd.Parameters.AddWithValue("@LoaiNcc", ncc.LoaiNcc);
                    cmd.Parameters.AddWithValue("@MoTa", ncc.MoTa);
                    cmd.Parameters.AddWithValue("@MaNcc", ncc.MaNcc);

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

        public bool xoaNhaCC(int maNCC)
        {
            try
            {
                _conn.Open();
                string SQL = "DELETE FROM NHACUNGCAP WHERE maNcc = @MaNcc";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNcc", maNCC);

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

        public DataTable timNhaCCTheoMaNcc(int maNCC)
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                string SQL = "SELECT * FROM NHACUNGCAP WHERE maNcc = @MaNcc";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNcc", maNCC); 

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

    }
}
