using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Class_Files
{
    public class User : IUser
    {
        private int  _userId;
        private string _userEmail;
        private string _passWord;
        private bool _isAdmin;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _dateCreated;
        private DateTime _lastLogin;

        public User()
        {
            _userId = 0;
            _userEmail = "testEmail";
            _passWord = "testPass";
            _isAdmin = false;
            _firstName = "testNameF";
            _middleName = "testMidNa";
            _lastName = "testLasN";
            _dateCreated = DateTime.Today;
            _lastLogin = DateTime.Today;
        }
        public User(int userIdInput, string userEmailInput, string passWordInput, bool isAdminInput, string firstNameInput,
            string middleNameInput, string lastNameInput, DateTime dateCreatedInput, DateTime lastLoginInput) 
        {
              _userId = userIdInput;
              _userEmail = userEmailInput;
              _passWord = passWordInput;
              _isAdmin = isAdminInput;
              _firstName = firstNameInput;
              _middleName = middleNameInput;
              _lastName = lastNameInput;
              _dateCreated = dateCreatedInput;
              _lastLogin = lastLoginInput;

        }

        public int userId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        public string userEmail
        {
            get
            {
                return _userEmail;
            }
            set
            {
                _userEmail = value;
            }
        }
        public string passWord
        {
            get
            {
                return _passWord;
            }
            set
            {
                _passWord = value;
            }
        }
        public bool isAdmin
        {
            get
            {
                return _isAdmin;
            }
            set
            {
                _isAdmin = value;
            }
        }
        public string firstName
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
        public string middleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }
        public string lastName
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
        public DateTime dateCreated
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                _dateCreated = value;
            }
        }
        public DateTime lastLogin
        {
            get
            {
                return _lastLogin;
            }
            set
            {
                _lastLogin = value;
            }
        }
    }
}