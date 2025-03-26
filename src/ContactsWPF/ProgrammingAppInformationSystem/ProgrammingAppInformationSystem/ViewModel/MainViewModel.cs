using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ProgrammingAppInformationSystem;

public class MainViewModel : INotifyPropertyChanged
{
    private const string ContactsFilePath = "contacts.xml";
    private Contact _selectedContact;
    private Contact _editingContact;
    private bool _isEditing;

    public ObservableCollection<Contact> Contacts { get; } = new ObservableCollection<Contact>();

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

    public Contact EditingContact
    {
        get => _editingContact;
        private set
        {
            _editingContact = value;
            OnPropertyChanged();
        }
    }

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

    public bool IsNotEditing => !IsEditing;

    public bool HasSelectedContact => SelectedContact != null;

    public ICommand AddCommand { get; }
    public ICommand EditCommand { get; }
    public ICommand RemoveCommand { get; }
    public ICommand ApplyCommand { get; }

    public MainViewModel()
    {
        AddCommand = new RelayCommand(_ => StartAdd(), _ => IsNotEditing);
        EditCommand = new RelayCommand(_ => StartEdit(), _ => IsNotEditing && HasSelectedContact);
        RemoveCommand = new RelayCommand(_ => RemoveContact(), _ => IsNotEditing && HasSelectedContact);
        ApplyCommand = new RelayCommand(_ => ApplyChanges(), _ => IsEditing);

        LoadContacts();
    }

    private void StartAdd()
    {
        SelectedContact = null;
        EditingContact = new Contact();
        IsEditing = true;
    }

    private void StartEdit()
    {
        if (SelectedContact != null)
        {
            EditingContact = new Contact { Name = SelectedContact.Name, Email = SelectedContact.Email, Phone = SelectedContact.Phone };
            IsEditing = true;
        }
    }

    private void CancelEdit()
    {
        IsEditing = false;
        if (SelectedContact == null)
        {
            EditingContact = null;
        }
        else
        {
            EditingContact = new Contact { Name = SelectedContact.Name, Email = SelectedContact.Email, Phone = SelectedContact.Phone };
        }
    }

    private void ApplyChanges()
    {
        if (SelectedContact == null)
        {
            // Adding new contact
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
            // Editing existing contact
            SelectedContact.Name = EditingContact.Name;
            SelectedContact.Email = EditingContact.Email;
            SelectedContact.Phone = EditingContact.Phone;
        }

        IsEditing = false;
        SaveContacts();
    }

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

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}