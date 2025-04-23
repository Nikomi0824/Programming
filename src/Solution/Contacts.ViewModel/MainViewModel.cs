using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Data;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    /// <summary>
    /// ViewModel главного окна приложения, управляющая коллекцией контактов
    /// и предоставляющая команды для работы с ними.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        private const string ContactsFilePath = "contacts.xml";

        private Contact _selectedContact;
        private Contact _editingContact;
        private bool _isEditing;
        private string _searchText = string.Empty;

        private ICollectionView _contactsView;

        /// <summary>
        /// Текст для поиска контактов
        /// </summary>
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                _contactsView?.Refresh(); 
            }
        }

        /// <summary>
        /// Коллекция контактов (ObservableCollection для автоматического обновления UI)
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; } = new ObservableCollection<Contact>();

        /// <summary>
        /// Выбранный контакт
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != value)
                {
                    if (_isEditing)
                    {
                        CancelEdit();
                    }

                    _selectedContact = value;
                    EditingContact = value != null ? new Contact { Name = value.Name, Email = value.Email, Phone = value.Phone } : null;
                    OnPropertyChanged();
                    CommandManager.InvalidateRequerySuggested(); 
                }
            }
        }

        /// <summary>
        /// Контакт в режиме редактирования (копия выбранного контакта)
        /// </summary>
        public Contact EditingContact
        {
            get => _editingContact;
            private set
            {
                _editingContact = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Флаг режима редактирования
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            private set
            {
                _isEditing = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotEditing)); 
                CommandManager.InvalidateRequerySuggested(); 
            }
        }

        /// <summary>
        /// Обратное свойство для IsEditing (удобно для привязок)
        /// </summary>
        public bool IsNotEditing => !IsEditing;

        /// <summary>
        /// Флаг наличия выбранного контакта
        /// </summary>
        public bool HasSelectedContact => SelectedContact != null;

  
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand ApplyCommand { get; }

        public MainViewModel()
        {
 
            _contactsView = CollectionViewSource.GetDefaultView(Contacts);
            _contactsView.Filter = FilterContacts;

     
            this.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(SearchText))
                {
                    _contactsView.Refresh();
                }
            };


            AddCommand = new CustomRelayCommand(_ => StartAdd(), _ => IsNotEditing);
            EditCommand = new CustomRelayCommand(_ => StartEdit(), _ => IsNotEditing && HasSelectedContact);
            RemoveCommand = new CustomRelayCommand(_ => RemoveContact(), _ => IsNotEditing && HasSelectedContact);
            ApplyCommand = new CustomRelayCommand(_ => ApplyChanges(), _ => CanApplyChanges());

    
            LoadContacts();
        }

        /// <summary>
        /// Фильтр контактов по тексту поиска
        /// </summary>
        private bool FilterContacts(object item)
        {
            if (string.IsNullOrWhiteSpace(_searchText))
                return true;

            if (item is Contact contact)
            {
                return (contact.Name?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0 ||
                       (contact.Email?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0 ||
                       (contact.Phone?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0;
            }

            return false;
        }

        /// <summary>
        /// Начало добавления нового контакта
        /// </summary>
        private void StartAdd()
        {
            SelectedContact = null;
            EditingContact = new Contact();
            IsEditing = true;
        }

        /// <summary>
        /// Начало редактирования контакта
        /// </summary>
        private void StartEdit()
        {
            if (SelectedContact != null)
            {
                EditingContact = new Contact
                {
                    Name = SelectedContact.Name,
                    Email = SelectedContact.Email,
                    Phone = SelectedContact.Phone
                };
                IsEditing = true;
            }
        }

        /// <summary>
        /// Отмена редактирования
        /// </summary>
        private void CancelEdit()
        {
            IsEditing = false;
            if (SelectedContact == null)
            {
                EditingContact = null;
            }
            else
            {
                EditingContact = new Contact
                {
                    Name = SelectedContact.Name,
                    Email = SelectedContact.Email,
                    Phone = SelectedContact.Phone
                };
            }
        }

        /// <summary>
        /// Применение изменений (добавление или сохранение)
        /// </summary>
        private void ApplyChanges()
        {
            if (SelectedContact == null)
            {
                var newContact = new Contact
                {
                    Name = EditingContact.Name,
                    Email = EditingContact.Email,
                    Phone = EditingContact.Phone
                };

                Contacts.Add(newContact);
                SelectedContact = newContact;
            }
            else
            {
                SelectedContact.Name = EditingContact.Name;
                SelectedContact.Email = EditingContact.Email;
                SelectedContact.Phone = EditingContact.Phone;
            }

            IsEditing = false;
            SaveContacts(); 
        }

        /// <summary>
        /// Удаление контакта
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact != null)
            {
                int index = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    SelectedContact = index >= Contacts.Count ? Contacts.Last() : Contacts[index];
                }
                else
                {
                    SelectedContact = null;
                }

                SaveContacts(); 
            }
        }

        /// <summary>
        /// Загрузка контактов из файла
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                if (File.Exists(ContactsFilePath))
                {
                    var loadedContacts = ContactSerializer.Deserialize(ContactsFilePath);
                    Contacts.Clear();
                    foreach (var contact in loadedContacts)
                    {
                        Contacts.Add(contact);
                    }

                    if (Contacts.Count > 0)
                    {
                        SelectedContact = Contacts[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load contacts: {ex.Message}");
            }
        }

        /// <summary>
        /// Сохранение контактов в файл
        /// </summary>
        private void SaveContacts()
        {
            try
            {
                ContactSerializer.Serialize(ContactsFilePath, Contacts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save contacts: {ex.Message}");
            }
        }

        /// <summary>
        /// Проверка возможности применения изменений
        /// </summary>
        private bool CanApplyChanges()
        {
            return IsEditing && EditingContact != null && !((INotifyDataErrorInfo)EditingContact).HasErrors;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}