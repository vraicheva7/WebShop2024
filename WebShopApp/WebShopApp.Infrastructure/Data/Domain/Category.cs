﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Infrastructure.Data.Domain
{
    public class Category
    { 
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; } = null!;
        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();

    }
}
