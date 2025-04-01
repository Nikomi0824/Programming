using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Contacts.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _searchText = string.Empty;

        private ICollectionView _contactsView;
        
        public MainViewModel()
        {
            // Инициализация представления коллекции
            _contactsView = CollectionViewSource.GetDefaultView(Contacts);
            _contactsView.Filter = FilterContacts;

            // Подписываемся на изменение текста поиска
            this.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(SearchText))
                {
                    _contactsView.Refresh();
                }
            };
        }

        private bool FilterContacts(object item)
        {
            if (string.IsNullOrWhiteSpace(SearchText))
                return true;

            if (item is Contact contact)
            {
                return contact.Name?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) == true ||
                       contact.Email?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) == true ||
                       contact.Phone?.Contains(SearchText, StringComparison.OrdinalIgnoreCase) == true;
            }

            return false;
        }
    }
} 