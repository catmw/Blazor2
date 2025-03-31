using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00172691_BlazorServer.Models.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage="Please enter name")]
        public string Name { get; set; } = string.Empty;

        public string? ImageName { get; set; }

        public double Price { get; set; }

        public string? description { get; set; }

        //Foreign Key
        [Range(1, 300, ErrorMessage = "Please enter number between 1 and 300")]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        [ValidateNever]
        public Category? Category { get; set; }
    }
}
