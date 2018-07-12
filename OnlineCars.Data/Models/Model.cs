using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
   public class Model
    {
        [Key]
        public int modelID { get; set; }

        public string modelAr { get; set; }

        public string modelEn { get; set; }


        public virtual ICollection<Car> Car { get; set; }

       


    }
}