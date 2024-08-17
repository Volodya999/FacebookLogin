using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
    public class NewUserRepo
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string BirthYear { get; set;}
        public string Gender { get; set; }  
    }
}
