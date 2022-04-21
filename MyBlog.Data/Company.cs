﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBlog.Data
{
   public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        
        public string Name { get; set; }
        public string Country { get; set; }


    }
}

