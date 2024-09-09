using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
    interface INewPostRepo
    {
        public int AddNewPost(NewPostRepo newPostRepo);
        public void InsertPostImages(int userid, string userimagepath, int postid);
        public DataTable GetPostInfo(int userid);
        public DataTable GetPostImages(int userid);
    }
}
