﻿using System.ComponentModel.DataAnnotations;

namespace BeginningCSharpAndDotNet_17_1_CodeFirstDatabase
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        [Key] public int Code { get; set; }


    }
}
