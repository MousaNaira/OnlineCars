using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
   public class Make
    {
        [Key]
        public int makeID { get; set; }

        public string makeEn { get; set; }
        public string makeAr { get; set; }
        public virtual ICollection<Car> Car { get; set; }
      



    }
}
