using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoa.Utilities
{
    class PhotoUtilities
    {
        public static Bitmap ByteToImage(byte[] img)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(img, 0, Convert.ToInt32(img.Length));
            Bitmap bm = new Bitmap(stream, false);
            stream.Dispose();
            return bm;
        }
    }
}
