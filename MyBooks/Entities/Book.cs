﻿using System;

namespace MyBooks.Entities
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}