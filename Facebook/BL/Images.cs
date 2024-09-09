﻿using Facebook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.BL
{
    public class Images
    {
        DataManager dm = new DataManager();
        public string GetUserImages(int userid)
        {
            string imgpath = string.Empty;
            try
            {
                ImagesRepo imagesRepo = new ImagesRepo()
                {
                  Id = userid
                };
                imgpath = dm.GetUserImages(imagesRepo);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return imgpath;           
        }
        public void InsertImages(int userid, string userimagepath, int postid)
        {
            try
            {
               dm.InsertImages(userid, userimagepath,postid);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
