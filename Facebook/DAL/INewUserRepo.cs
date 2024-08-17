using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
     interface INewUserRepo
    {
        public void NewUsersAccount(NewUserRepo newUserRepo);
        public DataTable GetBirthDay();
        public DataTable GetBirthDay(string procname);
        public DataTable GetBirthMonth();
        public DataTable GetBirthMonth(string procname);
        public DataTable GetBirthYear();
        public DataTable GetBirthYear(string procname);
        public DataTable GetGender();
        public DataTable GetGender(string procname);
        public int Login(NewUserRepo newUserRepo);
        public DataTable GetUserInfo(string useremail);

    }
}
