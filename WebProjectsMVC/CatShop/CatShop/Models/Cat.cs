﻿namespace CatShop.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Cat
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
