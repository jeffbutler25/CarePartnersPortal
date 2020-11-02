using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal.Classes
{
    public class Password
    {
        private static readonly string specialChar = "!#$%&*@";
        private static readonly string numbers = "123456789";
        private static readonly string lowerChar = "abcdefghjkmnpqrstuvwxyz";
        private static readonly string uppperchar = lowerChar.ToUpper();

        public static string New()
        {
            int upper = 2;
            int lower = 2;
            int number = 2;
            int special = 2;
            string password = GeneratePassword(upper, lower, number, special);
            return password;
        }

        public static string New(int upper, int lower, int number, int special)
        {
            string password = GeneratePassword(upper, lower, number, special);            
            return password;            
        }

        private static string GeneratePassword(int upper, int lower, int number, int special)
        {
            Random rng = new Random();
            string password = string.Empty;
            for (int i = 1; i <= upper; i++)
            {
                password = password.Insert(rng.Next(password.Length + 1), lowerChar[rng.Next(0, lowerChar.Length - 1)].ToString());
            }
            for (int i = 1; i <= lower; i++)
            {
                password = password.Insert(rng.Next(password.Length + 1), uppperchar[rng.Next(0, uppperchar.Length - 1)].ToString());
            }
            for (int i = 1; i <= number; i++)
            {
                password = password.Insert(rng.Next(password.Length + 1), numbers[rng.Next(0, numbers.Length - 1)].ToString());
            }
            for (int i = 1; i <= special; i++)
            {
                password = password.Insert(rng.Next(password.Length + 1), specialChar[rng.Next(0, specialChar.Length - 1)].ToString());
            }

            for (int i = 1; i < password.Length; i++)
            {
                if (i != password.Length - 1)
                {
                    if (password[i] == password[i + 1])
                    {
                        password = Password.GeneratePassword(upper, lower, number, special);
                    }
                }
            }
            return password;
        }

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                password =  GetSalt() + password;
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

        public static string DecodeFrom64(string encodedData)
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
            string salt = Password.New(8, 8, 8, 8);
            return salt;
        }

    }    
}
