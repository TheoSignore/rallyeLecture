using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture___ajout_eleves {
    class Hash {
        public static string GetSha256FromString(string password,string id) {
            string strid = Convert.ToString(id);
            using (MD5 md5Hash = MD5.Create()) {
                strid = GetMd5Hash(md5Hash, strid);
            }
            password = String.Format(strid + password);
            var message = Encoding.ASCII.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            string hex = "";
            var hashValue = hashstring.ComputeHash(message);
            foreach (byte x in hashValue) {
                hex += String.Format("{0:x2}",x);
            }
            return hex;
        }
        static string GetMd5Hash(MD5 md5Hash, string input) {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}

