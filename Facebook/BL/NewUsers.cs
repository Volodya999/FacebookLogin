using Facebook.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.BL
{
    public class NewUsers
    {
        DataManager dm = new DataManager();
        
        public void NewUsersAccount(string username, string userlastname, string useremail, string userpassword, int userbirthdayid, int userbirthmonthid, int userbirthyearid, int usergenderid)
        {
            try
            {
                NewUserRepo newUserRepo = new NewUserRepo()
                {
                    Name = username,
                    LastName = userlastname,
                    Email = useremail,
                    Password = userpassword,
                    BirthDay = userbirthdayid,
                    BirthMonth = userbirthmonthid.ToString(),
                    BirthYear = userbirthyearid.ToString(),
                    Gender = usergenderid.ToString(),
                };
                dm.NewUsersAccount(newUserRepo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthDay(string procname)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dm.GetBirthDay(procname);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthMonth(string procname)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dm.GetBirthMonth(procname);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthYear(string procname)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dm.GetBirthYear(procname);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetGender(string procname)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dm.GetGender(procname);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void MyLogs(string events, DateTime datetime, string logtext)
        {
            try
            {
                dm.MyLogs(events, datetime, logtext);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public int Login(string email, string password)
        {
            int user = 0;
            try
            {
                NewUserRepo newUserRepo = new NewUserRepo()
                {
                    Email = email,
                    Password = password
                };
                user = dm.Login(newUserRepo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return user;
        }
        public DataTable GetUserInfo(string useremail)
        {
            DataTable dt = new DataTable();
            try
            {
               dt= dm.GetUserInfo(useremail);
            }
            catch (Exception ex)
            {

                throw;
            }
            return  dt;
        }
    }
}
