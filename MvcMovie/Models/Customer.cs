using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string NoOfTicket { get; set; }

        [Required]
        public string MovieName { get; set; }

        // Add other customer properties as needed
    }
}
