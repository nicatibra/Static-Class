namespace Static_Class
{
    internal static class Helper
    {
        public static bool IsOdd(this int number)
        {
            if (number == 0)
            {
                return false;
            }
            else if (number % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int number)
        {
            if (number == 0)
            {
                return false;
            }
            else if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool HasDigit(this string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;

            //foreach ilə yazılış
            //foreach (char c in word)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public static bool CheckPassword(this string password)
        {
            // Regex ilə yazılış
            //return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");

            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }
            }
            return false;
        }

        public static string Capitalize(this string word)
        {
            return word.Trim().Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
    }
}
