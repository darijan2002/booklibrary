﻿using Microsoft.EntityFrameworkCore;
using System;
namespace BookLibrary.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}