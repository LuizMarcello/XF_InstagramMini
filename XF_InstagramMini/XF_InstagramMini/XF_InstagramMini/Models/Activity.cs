﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace XF_InstagramMini.Models
{
    public class Activity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { 
            get
            {
               return "http://lorempixel.com/100/100/people/" + UserId;
            } 
        }
    }
}

