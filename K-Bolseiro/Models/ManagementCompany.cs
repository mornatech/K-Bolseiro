using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K_Bolseiro.Models
{
    public class ManagementCompany
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }
        public string telephone { get; set; }
        public virtual ICollection<ManagingCompanyStaff> ManagingStaff { get; set; }
        
    }
}