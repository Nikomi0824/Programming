using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Методы для проверки значений
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Метод проверки на правильность ввода номера.
        /// </summary>
        public static bool ValidateNumber(string number)
        {
            if (!string.IsNullOrWhiteSpace(number))
            {
                return Regex.IsMatch(number, "^[+]7[0-9]{10}$");
            }
            return true;
        }

        /// <summary>
        /// Метод проверки на правильность ввода имени контакта.
        /// </summary>
        public static bool ValidateContactName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                string pattern = @"^[a-zA-Zа-яА-Я\s]+$";
                return Regex.IsMatch(name, pattern);
            }
            return true;
        }

        /// <summary>
        /// Метод проверки на правильность ввода почты.
        /// </summary>
        public static bool ValidateEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            return true;
        }
    }
}