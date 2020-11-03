using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class PasswordService
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
                        password = PasswordService.GeneratePassword(upper, lower, number, special);
                    }
                }
            }
            return password;
        }



    }    
}
