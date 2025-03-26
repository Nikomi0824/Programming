using System;
using System.Text;
using Contacts.Model.Services;

namespace Contacts.Model
{
    /// <summary>
    /// Хранит контактные данные телефона.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string? _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя контакта. Может содержать русские и английские буквы.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта. Должен быть Российский код номера.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Должен соответствовать формату почты.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно содержать русские и английские буквы.</param>
        /// <param name="number">Номер телефона контакта по типу +7XXXXXXXXXX.</param>
        /// <param name="Email">Адрес электронной почты. Должен соответствовать формату.</param>
        public Contact(string name, string number, string email)
        {
            Name = name;
            PhoneNumber = number;
            Email = email;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }
    }
}