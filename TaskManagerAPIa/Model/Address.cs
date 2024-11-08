﻿
using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPIa.Model
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public string? City { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

    }
}
