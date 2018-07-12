using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCars.Models
{
    public class CarViewModel
    {
        public int CarID { get; set; }
        public String Image { get; set; }

        public string Description_Ar { get; set; }
        public string Description_En { get; set; }

        public int imgCount { get; set; }

        public string SharingLink { get; set; }

        public string mileage { get; set; }
        public int year { get; set; }

        public int makeID { get; set; }

        public string makeEn { get; set; }
        public string makeAr { get; set; }


        public int modelID { get; set; }

        public string modelAr { get; set; }

        public string modelEn { get; set; }

        public int bodyId { get; set; }

        public string bodyEn { get; set; }

        public string SharingMsgAR { get; set; }
        public string SharingMsgEn { get; set; }

        public string bodyAr { get; set; }

        public AdditionalInfoViewModel AdditionalInfo { get; set; }

    }
}