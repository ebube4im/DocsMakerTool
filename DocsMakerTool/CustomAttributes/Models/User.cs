using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsMakerTool.CustomAttributes.Models
{
    [Document("This is a class that checks a User")]
    internal class User
    {
        public int Id { get; set; }

        [Document("This is a property showing the name")]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        [Document("This is a Constructor","This takes in nothing and returns nothing")]
        public User() { }

        [Document("This is a method!", "Input: User", "Ouput: void")]
      public  string UpdateUser(User user)
        {
            return "";
        }

        [Document("This is an Enum of that shows usertype!")]
      public  enum Usertype
        {
            employee,
            admin,
            manager,
            supervisor
        }
        

    }
}
