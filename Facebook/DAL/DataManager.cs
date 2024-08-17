using log4net;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
    public class DataManager : INewUserRepo, IImagesRepo
    {
        private readonly SqlConnection con;
        private readonly ILog logs = LogManager.GetLogger("Facebook");
        public DataManager()
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-ISS05J1O\MSSQLSERVER01;Initial Catalog=Facebook_login;Integrated Security=true;TrustServerCertificate=True";
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #region public functions
        public int Login(NewUserRepo newUserRepo)
        {
            int users = 0;
            try
            {
                users = ReturnValues("Login",
                new SqlParameter("@useremail", newUserRepo.Email),
                new SqlParameter("@userpassword", newUserRepo.Password));
            }
            catch (Exception ex)
            {
                logs.Info(ex.Message);
                throw new Exception(ex.Message);
            }
            return users;

        }
        public void NewUsersAccount(NewUserRepo newUserRepo)
        {
            try
            {
                Executewithparams("NewUsersAccount",
                new SqlParameter("@username", newUserRepo.Name),
                new SqlParameter("@userlastname", newUserRepo.LastName),
                new SqlParameter("@useremail", newUserRepo.Email),
                new SqlParameter("@userpassword", newUserRepo.Password),
                new SqlParameter("@userbirthdayid", newUserRepo.BirthDay),
                new SqlParameter("@userbirthmonthid", newUserRepo.BirthMonth),
                new SqlParameter("@userbirthyearid", newUserRepo.BirthYear),
                new SqlParameter("@usergenderid", newUserRepo.Gender));
            }
            catch (Exception ex)
            {
                logs.Info(ex.Message);
                throw new Exception(ex.Message);
            }
            
        }
        public DataTable GetBirthDay()
        {
            int a = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("GetBirthDay", con);
                cmd.Connection = con;   
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthDay(string procname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public DataTable GetBirthMonth()
        {
            string a = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("BirthMonth", con);
                cmd.Connection = con;
                cmd.CommandType= CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthMonth(string procname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procname);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthYear()
        {
            int a = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("GetBirthYear", con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetBirthYear(string procname) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetGender()
        {
            string a = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("GetGender", con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable GetGender(string procname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
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
                MyLogs("MyLogs",
                new SqlParameter("@event", events),
                new SqlParameter("@datetime", datetime),
                new SqlParameter("@logtext", logtext));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public string GetUserImages(ImagesRepo imagesRepo)
        {
            string getimagepath = String.Empty;
            try
            {
                getimagepath = ExecutewithScalar("GetUserImage",
                     new SqlParameter("userid", imagesRepo.Id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return getimagepath;
        }
        public DataTable GetUserInfo(string useremail)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand com = new SqlCommand("GetUserInfo", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@useremail", useremail);
                SqlDataAdapter adap =  new SqlDataAdapter(com);
                adap.Fill(dt);

            }
            catch (Exception ex)
            {

                throw;
            }
            return dt;
        }
        public void InsertImages(int userid, string userimagepath)
        {
            try
            {
                 Executewithparams("InsertImages",
                    new SqlParameter("userid", userid),
                    new SqlParameter("@userimagepath", userimagepath));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region private functions
        private void Executewithparams(string procname, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private string ExecutewithScalar(string procname, params SqlParameter[] parameters)
        {
            try
            {
                string returnvalue = string.Empty;
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                returnvalue = cmd.ExecuteScalar().ToString();
                return returnvalue;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        private int ReturnValues(string procname, params SqlParameter[] parameters)
        {
            int returnvalue = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                returnvalue = Convert.ToInt32(cmd.ExecuteScalar());
                return returnvalue;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        private void MyLogs(string procname, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(procname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
