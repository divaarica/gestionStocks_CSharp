using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppSouleymaneFaye.Util
{
    public static class Crypt
    {

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            //convert the input string to a byte array and compute
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //create e new Stringbuilder to collect bytes
            //and create a string
            StringBuilder sb = new StringBuilder();

            //loop through each byte of the hashed data
            //and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            //return the hexadecimal string

            return sb.ToString();


        }

        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash) { 

            //hash yhe input
            string hashOfInput = GetMd5Hash(md5Hash, input);

            //create a stringcomparer an compare the hsahes
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if(0== comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
