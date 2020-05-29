using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;

namespace CraftsnMoreGalore.Models
{
    public class Customer
    {
        [Required]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Number { get; set; }

        public Customer() { }

        public Customer(string name, string emailAddress, string number)
        {
            Name = name;
            EmailAddress = emailAddress;
            Number = number;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Email Address: {EmailAddress}");
            sb.AppendLine($"Phone Number: {Number}");

            return sb.ToString();
        }
    }
}