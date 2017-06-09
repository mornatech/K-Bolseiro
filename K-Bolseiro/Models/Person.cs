using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace K_Bolseiro.Models
{
    public abstract class Person : ApplicationUser
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Last Name")]
        public string Surname { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + Surname;
            }
        }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Address Line 1 ")]
        public string Address1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }
      


    }
}