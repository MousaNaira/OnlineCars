using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
   public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string Image { get; set; }

        public string Description_Ar { get; set; }
        public string Description_En { get; set; }

        public int imgCount { get; set; }

        public string SharingLink { get; set; }

        public string mileage { get; set; }

     

        public int year { get; set; }

      



        
        public virtual int AdditionalInfoID { get; set; }

        public virtual AdditionalInfo AdditionalInfo { get; set; }

        public virtual int CompanyID { get; set; }

        public virtual AuctionCompany AuctionCompany { get; set; }

        public virtual int modelID { get; set; }

        public virtual Model Model { get; set; }


        public virtual int makeID { get; set; }

        public virtual Make Make { get; set; }


        public virtual int bodyId { get; set; }

        public virtual Body Body { get; set; }
    }
}
