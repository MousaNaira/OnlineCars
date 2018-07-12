using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Data.Models
{
  public  class OnlineCarsContext:DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        public virtual DbSet<Make> Makes { get; set; }

        public virtual DbSet<Body> Bodies { get; set; }

        public virtual DbSet<AdditionalInfo> AdditionalInfo { get; set; }

        public virtual DbSet<AuctionCompany> AuctionCompanies { get; set; }
    }
}
