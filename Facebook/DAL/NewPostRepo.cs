﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.DAL
{
    public class NewPostRepo
    {
        public int Id { get; set; }
        public int UserId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photos { get; set; }
        public DateTime DateTime { get; set; }
        public int postid { get; set; }

    }
}
