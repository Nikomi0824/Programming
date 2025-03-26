using Contacts.Model.Services;
using Contacts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Common;
using Contacts.ViewModel;

namespace Contacts.ViewModel
{
    /// <summary>
    /// ViewModel для работы с контактами. <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Событие, для отслеживаня изменений в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает и задаёт значение имя контакта. Вызывает событие.
        /// </summary>
        public string? Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение номера телефона контакта. Вызывает событие.
        /// </summary>
        public string? PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение почты контакта. Вызывает событие.
        /// </summary>
        public string? Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает и задаёт команду для созранения контакта<see cref="Contact"/>.
        /// </summary>
        public ICommand SaveCommand { get; set; }

        /// <summary>
        /// Возвращает и задаёт команду для загрузки контакта<see cref="Contact"/>.
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand(_contact);
            LoadCommand = new LoadCommand(contact =>
            {
                _contact = contact;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            });
        }
        

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (!ValueValidator.ValidateContactName(Name))
                        {
                            error = "Имя может содержать русские и английские буквы";
                        }
                        break;
                    case "PhoneNumber":
                        if (!ValueValidator.ValidateNumber(PhoneNumber))
                        {
                            error = "Должен быть Российский код номера";
                        }
                        break;
                    case "Email":
                        if (!ValueValidator.ValidateEmail(Email))
                        {
                            error = "Должен соответствовать формату почты";
                        }
                        break;
                }
                return error;
            }
        }

        public string Error
        {
            get { return null; } // или верните общее сообщение об ошибке
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="property">Название изменённого свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}