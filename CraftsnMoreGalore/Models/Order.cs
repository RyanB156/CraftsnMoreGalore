using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using CraftsnMoreGalore.Models;

namespace CraftsnMoreGalore.Models
{
    public class Order
    {
        public Customer Customer { get; set; }

        [Required]
        [Display(Name ="Order")]
        public string Description { get; set; }

        public Order() { }

        public Order(Customer customer, string description)
        {
            Customer = customer;
            Description = description;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Customer: {Customer}");
            sb.AppendLine($"Description: {Description}");

            return sb.ToString();
        }
    }
}