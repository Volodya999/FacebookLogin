using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
    interface IImagesRepo
    {
        public string GetUserImages(ImagesRepo imagesRepo);
        public void InsertImages(int userid, string userimagepath, int postid);
    }
}
