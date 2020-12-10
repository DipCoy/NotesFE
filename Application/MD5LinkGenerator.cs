using System.Linq;
using System.Security.Cryptography;


namespace Application
{
    public class MD5LinkGenerator : ILinkGenerator
    {
        private readonly RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        
        public string NewLink()
        {
            var bytes = new byte[12];
            rngCsp.GetBytes(bytes);
            var hashEncoded = MD5.Create().ComputeHash(bytes);
            var link = hashEncoded.Select(b => b.ToString("x2"));
            return string.Join(null, link);
        }
    }
}