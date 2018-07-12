using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
    public class AdditionalInfo
    {
        [Key]
        public int AdditionalInfoID { get; set; }

        public int bids { get; set; }
        public long endDate { get; set; }

        public DateTime endDateEn { get; set; }

        public DateTime endDateAr { get; set; }

        public string currencyEn { get; set; }
        public string currencyAr { get; set; }

        public double currentPrice { get; set; }
        public double minIncrement { get; set; }

        public long lot { get; set; }
        public int priority { get; set; }
        public int VATPercent { get; set; }

        public int isModified { get; set; }

        public int itemid { get; set; }

        public int iCarId { get; set; }

        public string iVinNumber { get; set; }

        public virtual ICollection<Car> Car { get; set; }

    }
}
