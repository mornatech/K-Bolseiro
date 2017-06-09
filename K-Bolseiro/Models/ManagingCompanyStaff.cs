using System.ComponentModel.DataAnnotations;

namespace K_Bolseiro.Models
{
    public class ManagingCompanyStaff : ApplicationUser
    {
        
        public string email { get; set; }
        public string department { get; set; }
        public bool admin { get; set; }

        public virtual ManagementCompany ManagementCompany { get; set; }
         
    }
}