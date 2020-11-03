using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class EncryptionService
    {
        public static string EncodeString(string password)
        {
            try
            {
                password = GetSalt() + password;
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public static string DecodeString(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            result = result.Substring(32);
            return result;
        }

        private static string GetSalt()
        {
            string salt = PasswordService.New(8, 8, 8, 8);
            return salt;
        }

    }
}
