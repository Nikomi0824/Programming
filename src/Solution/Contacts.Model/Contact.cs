using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Contacts.Model
{
    public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        private string _name;
        private string _email;
        private string _phone;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                ValidateName();
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                ValidateEmail();
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                ValidatePhone();
                OnPropertyChanged();
            }
        }

        private void ValidateName()
        {
            ClearErrors(nameof(Name));
            if (string.IsNullOrWhiteSpace(_name))
                AddError(nameof(Name), "Name is required.");
            else if (_name.Length > 100)
                AddError(nameof(Name), "Name must not exceed 100 characters.");
        }

        private void ValidateEmail()
        {
            ClearErrors(nameof(Email));
            if (string.IsNullOrWhiteSpace(_email))
                AddError(nameof(Email), "Email is required.");
            else if (_email.Length > 100)
                AddError(nameof(Email), "Email must not exceed 100 characters.");
            else if (!_email.Contains("@"))
                AddError(nameof(Email), "Email must contain '@' symbol.");
        }

        private void ValidatePhone()
        {
            ClearErrors(nameof(Phone));
            if (string.IsNullOrWhiteSpace(_phone))
                AddError(nameof(Phone), "Phone number is required.");
            else if (_phone.Length > 100)
                AddError(nameof(Phone), "Phone number must not exceed 100 characters.");
            else if (!Regex.IsMatch(_phone, @"^[0-9+\-() \.]+$"))
                AddError(nameof(Phone), "Phone number can only contain digits and +-() characters.");
        }

        private void AddError(string propertyName, string error)
        {
            if (!_errors.ContainsKey(propertyName))
                _errors[propertyName] = new List<string>();

            if (!_errors[propertyName].Contains(error))
            {
                _errors[propertyName].Add(error);
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        private void ClearErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
            {
                _errors.Remove(propertyName);
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        public bool HasErrors => _errors.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}