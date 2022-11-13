using System.Security.Cryptography;
using System.Text;

namespace vetClinic.API.Security
{
    public class PasswordEncriptionHelper
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            string salt = "";

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buf);
                salt = Convert.ToBase64String(buf);
            }

            //var buf = new byte[16];
            //(new RNGCryptoServiceProvider()).GetBytes(buf);
            //return Convert.ToBase64String(buf);
            return salt;
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA2");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
