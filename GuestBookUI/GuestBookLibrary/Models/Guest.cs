using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class Guest
    {
        private string _firstName { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        private string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        private string _message { get; set; }
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if(value.Length < 256)
                {
                    _message = value;
                }
                else
                {
                    throw new ArgumentException("Message", "Message is longer than 256 characters");
                }
            }
        }
    }
}
