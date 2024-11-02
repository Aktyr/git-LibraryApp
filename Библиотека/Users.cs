using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class Users
    {
        public List<User> users; 

        public Users() 
        { 
            users = new List<User>();
        }

        public void AddUser
            (string lastName, 
            string firstName, 
            string middleName, 
            string contactInfo, 
            string password)
        {
            var user = new User(lastName, firstName, middleName, contactInfo, password);
            users.Add(user);
        }
    
    }
    public class User
    {
        
        public string lastName; //Фамилия
        public string firstName; //Имя
        public string middleName; //Отчетво

        public string contactInfo;
        private string password;

        public int userId;
        public bool subscriptionStatus;
        public Book issuedBook;


        //доделать
        public User(string LastName, string FirstName, string MiddleName, string ContactInfo, string Password)
        {
            lastName = LastName;
            firstName = FirstName;
            middleName = MiddleName;
            contactInfo = ContactInfo;
            password = Password;

            //subscriptionStatus = false;
            //issuedBook = ;
            //userId = ;
        }
    }
}
