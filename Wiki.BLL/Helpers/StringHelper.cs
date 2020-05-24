using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Wiki.BLL.Helpers
{
    public static class StringHelper
    {
        public static string AsCommonsMediaSource(this string title)
        {
            using (MD5 md5 = MD5.Create())
            {
                title = title.Replace(" ", "_");
                byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(title));
                var ab = hash.First().ToString("x2");
                return $"https://upload.wikimedia.org/wikipedia/commons/{ab[0]}/{ab[0]}{ab[1]}/{title}";
            }
        }

        public static List<string> ToStringList(this string str) 
            => new List<string> { str };

        public static List<string> ToStringList(this string str, char separator) 
            => str.Split(separator).ToList();
    }
}
