﻿using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        [Range(0, 50, ErrorMessage = "Maxgränsen är 50 st.")]
        public int Count { get; set; }
        public string Description { get; set; }

    }
}
