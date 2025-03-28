using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgrammingAppInformationSystem.Model
{
    public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private string _name;
        private string _email;
        private string _phone;
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                    ValidateName();
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                    ValidateEmail();
                }
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged();
                    ValidatePhone();
                }
            }
        }

        public bool IsReadOnly { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        public bool HasErrors => _errors.Count > 0;

        private void ValidateName()
        {
            ClearErrors(nameof(Name));
            if (string.IsNullOrWhiteSpace(Name))
            {
                AddError(nameof(Name), "Name is required");
            }
            else if (Name.Length > 100)
            {
                AddError(nameof(Name), "Name cannot be longer than 100 characters");
            }
        }

        private void ValidateEmail()
        {
            ClearErrors(nameof(Email));
            if (string.IsNullOrWhiteSpace(Email))
            {
                AddError(nameof(Email), "Email is required");
            }
            else if (Email.Length > 100)
            {
                AddError(nameof(Email), "Email cannot be longer than 100 characters");
            }
            else if (!Email.Contains("@"))
            {
                AddError(nameof(Email), "Email must contain @ symbol");
            }
        }

        private void ValidatePhone()
        {
            ClearErrors(nameof(Phone));
            if (string.IsNullOrWhiteSpace(Phone))
            {
                AddError(nameof(Phone), "Phone is required");
            }
            else if (Phone.Length > 100)
            {
                AddError(nameof(Phone), "Phone cannot be longer than 100 characters");
            }
            else if (!Regex.IsMatch(Phone, @"^[\d\s\-\+\(\)]+$"))
            {
                AddError(nameof(Phone), "Phone can only contain digits, spaces, and symbols +-()");
            }
        }

        private void AddError(string propertyName, string error)
        {
            if (!_errors.ContainsKey(propertyName))
            {
                _errors[propertyName] = new List<string>();
            }
            if (!_errors[propertyName].Contains(error))
            {
                _errors[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        private void ClearErrors(string propertyName)
        {
            if (_errors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}