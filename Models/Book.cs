﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_Base.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public int Pages { get; set; }

        public ushort Price { get; set; }

        public DateTime PublishDate { get; set; }


        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int ThemeId { get; set; }

        public Theme Theme { get; set; }
    }
}
