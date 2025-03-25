using System;
using System.Windows.Input;
using Contacts.Model.Services;
using Contacts.Model;

namespace Contacts.ViewModel
{
    public class LoadCommand : ICommand
    {
        private readonly Action<Contact> _setContact;

        public LoadCommand(Action<Contact> setContact)
        {
            _setContact = setContact;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var contact = ContactSerializer.LoadContact();
            _setContact(contact);
        }
    }
}