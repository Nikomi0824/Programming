using System;
using System.Windows.Input;
using Contacts.Model.Services;
using Contacts.Model;

namespace Contacts.ViewModel
{
    public class SaveCommand : ICommand
    {
        private readonly Contact _contact;

        public SaveCommand(Contact contact)
        {
            _contact = contact;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            ContactSerializer.SaveContact(_contact);
        }
    }
}