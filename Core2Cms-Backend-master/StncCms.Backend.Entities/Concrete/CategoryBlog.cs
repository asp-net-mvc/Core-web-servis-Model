﻿using System;
using System.Collections.Generic;
using System.Text;
using StncCms.Backend.Entities.Interfaces;

namespace StncCms.Backend.Entities.Concrete
{
    public class CategoryBlog : ITable
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        /* 
         1 => 1
         1=> 1
         */
    }
}
