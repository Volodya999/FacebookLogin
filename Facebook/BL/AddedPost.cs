using Facebook.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.BL
{
    public class AddedPost
    {
        DataManager dm = new DataManager();
        public DataTable GetPostInfo(int userid, string Description, DateTime datetime)
        {
            DataTable dt = new DataTable();
            try
            {
                dm.GetPostInfo(userid);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return dt;
            
        }
        
    }
}
