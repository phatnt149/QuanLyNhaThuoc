using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT.Untils
{
   public static class ImageUntils
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;

            using (Bitmap bmp = new Bitmap(imageIn))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // chọn định dạng cố định
                return ms.ToArray();
            }
        }

        public static Image SelectImageFromFile()
        {
            OpenFileDialog open = new OpenFileDialog();  // Tạo hộp thoại chọn file
            open.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            // Chỉ cho phép chọn file ảnh .jpg, nhưng nếu muốn có thể chọn tất cả file
            open.FilterIndex = 1;  // Mặc định chọn bộ lọc đầu tiên (JPG)
            open.RestoreDirectory = true; // Sau khi đóng dialog thì thư mục hiện tại quay lại như ban đầu

            if (open.ShowDialog() == DialogResult.OK)   // Nếu người dùng bấm "OK"
            {
                return Image.FromFile(open.FileName);   // Trả về đối tượng Image từ file đã chọn
            }
            return null; // Nếu bấm Cancel thì không chọn → trả về null
        }
    }
}
