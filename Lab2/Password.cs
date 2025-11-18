using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordForm
{
    public class Password
    {
        private string pword;

        public Password(string password)
        {
            Pword = password;
        }

        public string Pword
        {
            get { return pword; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Пароль не может быть пустым или состоять только из пробелов");
                    return;
                }
                else 
                {
                    Console.WriteLine("Пароль установлен успешно");
                    pword = value;
                }
            }
        }

        public bool Check()
        {
            if (pword.Length < 6 || pword.Length > 12)
                throw new ArgumentException("Пароль недопустимой длины (6-12)");

            if (pword.All(Char.IsDigit))
                throw new ArgumentException("Пароль не должен состоять только из цифр");

            if (pword.All(Char.IsLetter))
                throw new ArgumentException("Пароль не должен состоять только из букв");

            return true;
        }

        public static Password operator -(Password pw, char value)
        {
            string newPword = pw.Pword.Substring(0, pw.Pword.Length - 1) + value;
            return new Password(newPword);
        }

        public static bool operator >(Password pw1, Password pw2)
        {
            return pw1.Pword.Length > pw2.Pword.Length;
        }

        public static bool operator <(Password pw1, Password pw2)
        {
            return pw1.Pword.Length < pw2.Pword.Length;
        }

        public static bool operator !=(Password pw1, Password pw2)
        {
            return pw1.Pword != pw2.Pword;
        }

        public static bool operator ==(Password pw1, Password pw2)
        {
            return pw1.Pword == pw2.Pword;
        }

        public static Password operator ++(Password pw)
        {
            string newPword = "qwerty123";
            return new Password(newPword);
        }

        public static bool operator true(Password pw)
        {
            try
            {
                pw.Check();
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool operator false(Password pw)
        {
            try
            {
                pw.Check();
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
