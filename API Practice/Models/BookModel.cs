﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Practice.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

       public BookModel(int Id, string title,string Description) {
        this.Description = Description;
            this.Title = title;
            this.Id = Id;
         
        }
    }
}