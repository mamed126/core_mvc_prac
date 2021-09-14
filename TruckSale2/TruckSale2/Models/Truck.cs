using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TruckSale2.Models
{
    public class Truck
    {
        public int Id { get; set; }

        [Display(Name ="Truck brand")]
        [Required]
        [StringLength(maximumLength:25,ErrorMessage ="Brand nam max length is 25 simvols")]
        public string Brand { get; set; }

        [Display(Name ="Model of truck")]
        public string Model { get; set; }

        [Display(Name ="Truck registered")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        public List<string> Distributors { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
