using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordForm
{
    public static class PasswordHelper
    {
        public static char GetMediumChar(this string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new InvalidOperationException("Строка пустая");
            if (str.Length % 2 == 0)
                return str[(str.Length / 2) - 1];
            else
                return str[str.Length / 2];
        }

        public static bool CorrectLength(this Password pw)
        {
            return pw.Pword.Length >= 6 && pw.Pword.Length <= 12;
        }
    }
}
