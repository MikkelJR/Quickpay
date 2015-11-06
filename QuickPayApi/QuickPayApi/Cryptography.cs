using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace QuickPayApi
{
    public class Cryptography
    {
        public static string CreateToken(string message, string key)
        {
            var myhmacsha1 = new HMACSHA256(Encoding.ASCII.GetBytes(key));
            var byteArray = Encoding.ASCII.GetBytes(message);
            var stream = new MemoryStream(byteArray);
            return myhmacsha1.ComputeHash(stream).Aggregate("", (s, e) => s + $"{e:x2}", s => s);
        }
    }
}