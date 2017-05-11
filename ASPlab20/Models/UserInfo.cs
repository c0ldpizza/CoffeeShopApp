using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPlab20.Models
{
    public class UserInfo
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private string Phone;
        private string Password;

        #region
        public string UserFirstName
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string UserLastName
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string UserEmail
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string UserPhone
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }
        #endregion

        //default constructor just passes blank strings to regular constructor
        public UserInfo():this("","","","","")
        {
            
        }

        public UserInfo(string firstName, string lastName, string email, string phone, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }
}