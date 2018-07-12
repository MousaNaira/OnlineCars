using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
    public  class AuctionCompany
    {
        [Key]
        public int CompanyID { get; set; }

        public string CompanyNameEn { get; set; }

        public string CompanyNameAr { get; set; }

        public virtual ICollection <Car>Car { get; set; }
    }
}
