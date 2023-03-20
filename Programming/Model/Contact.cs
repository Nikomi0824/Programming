using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;
        
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public Contact(string _name,string _email,  string _phoneNumber)
        {
            Name = _name;
            Email = _email;
            PhoneNumber = _phoneNumber;
        }
        public Contact() { }
    }
}
