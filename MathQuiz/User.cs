using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    public class User
    {
        //Single argument constructor that takes in a name. 
       public User(string passedInUserName) 
        {
            UserName = passedInUserName;
        }
        private string userName = "John";
        public string UserName
        {
            get;
            set;
        }
        //This function returns a string using the user's name, sending it to the form. 
        public string makeGreeting() 
        {
            string greeting = "Hello " + UserName;
            return greeting;
        }
    }
}
