using Facebook.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.BL
{
    public class NewPost
    {
        DataManager dm = new DataManager();
        public int AddPost(int UserId,string Title,string Description ,DateTime dateTime)
        {
            int postid = 0;
            NewPostRepo np = new NewPostRepo()
            {
                UserId = UserId,
                Title = Title,
                Description = Description,
                DateTime = DateTime.Now
            };
           postid= dm.AddNewPost(np);
            return postid;
        }
        public void InsertPostImages(int userid, string[] postimgpath, int postid)
        {
            for (int i = 0; i < postimgpath.Length; i++)
            {
                try
                {
                    dm.InsertPostImages(userid, postimgpath[i], postid);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public DataTable GetPostInfo(int userid)
        {
            DataTable dt = new DataTable();
            try
            {
               dt= dm.GetPostInfo(userid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
        public DataTable GetPostImages(int postid)
        {
            DataTable dt = new DataTable();
            try
            {
              dt=dm.GetPostImages(postid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }
    }
}
