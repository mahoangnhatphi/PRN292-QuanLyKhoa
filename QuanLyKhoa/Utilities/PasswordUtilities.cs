using System.Security.Cryptography;
using System.Text;

namespace QuanLyKhoa.Util
{
    class PasswordUtilities
    {

       public static byte[] EncodingPassword(string password)
       {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return provider.ComputeHash(encoding.GetBytes(password));
       }
    }
}
