using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class UserLogin
    {
        public string username;
        public string password;

        public UserLogin(string n, string p)
        {
            username = n;
            password = p;
        }
    }
    public class UserCreate
    {
        public string username;
        public string firstname;
        public string lastname;
        public string password;

        public UserCreate(string n, string f, string l, string p)
        {
            username = n;
            firstname = f;
            lastname = l;
            password = p;
        }
    }
    public class Users
    {
        private int id;
        private string username;
        private string firstname;
        private string lastname;
        private bool admin;
        private string password;

        public static List<Users> allUsers = new List<Users>();

        public static Users userSelected;

        public Users() { }

        public Users(int Id, string Username, string Firstname, string Lastname, bool Admin, string Password)
        {
             id = Id;
             username = Username ;
             firstname = Firstname ;
             lastname = Lastname ;
             admin = Admin ;
            password = Password;
        }
        public Users(string Username, string Firstname, string Lastname, string Password)
        {
            username = Username;
            firstname = Firstname;
            lastname = Lastname;
            password = Password;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        //public List<string> headers = new List<string> { "id", "username", "Firstname", "Lastname", "Admin" };

        public static async void getAllUsers()
        {
            string response = await api.getAllAsync("/users");

            foreach (object obj in response)
            {
                Users user = JsonConvert.DeserializeObject<Users>(obj.ToString());
                allUsers.Add(user);
            }



            
        }

        public static async void getOneUser(int id)
        {


            object response = await api.getOneAsync("/users/"+id);
            
                var res = JsonConvert.DeserializeObject<Users>(response.ToString());

                allUsers.Add(res);

            

            


        }
    }
}
