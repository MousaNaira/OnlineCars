using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
  public class Body
    {
        [Key]
        public int bodyId { get; set; }

        public string bodyEn { get; set; }

        public string bodyAr { get; set; }

        public virtual ICollection<Car> Car { get; set; }

      
    }
}
