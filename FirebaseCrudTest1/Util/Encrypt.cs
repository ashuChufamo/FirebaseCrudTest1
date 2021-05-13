using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FirebaseCrudTest1.Util
{
    

    namespace studentManagment
    {
        public class Encrypt
        {
            public static string GetShaData(string data)
            {
                SHA1 sha = SHA1.Create();
                Byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(data));
                StringBuilder returnValue = new StringBuilder();
                int i;
                for (i = 0; i < hashData.Length - 1; i++)
                {
                    returnValue.Append(hashData[i].ToString());
                }
                return returnValue.ToString();
            }
        }
    }
}
