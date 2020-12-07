using System;
using System.Linq;
using System.Security.Cryptography;

namespace Domain.Models
{
    public class Board//entity
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public Guid Id { get; private set;}
        public string Link { get; private set; }
        public BoardContent Content { get; private set; }
        
        public Board(BoardContent content)
        {
            Console.WriteLine(Link);
            Content = content;
        }

        public void GenerateNewLink()
        {
            var bytes = new byte[12];
            rngCsp.GetBytes(bytes);

            var hashEncoded = MD5.Create().ComputeHash(bytes);
            foreach (var b in hashEncoded)
            {
                Link += b.ToString("x2");
            }
            Console.WriteLine(Link);
        }
    }
}