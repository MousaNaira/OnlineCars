namespace OnlineCars.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineCars.Data.Models.OnlineCarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnlineCars.Data.Models.OnlineCarsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Models.AddOrUpdate(
                 new Models.Model() { modelAr = "—Ì‰Ê", modelEn = "Renault" }
                );

            context.Makes.AddOrUpdate(
                 new Models.Make() { makeAr = "·ÊÃ«‰", makeEn = "Logan" }
                );

            context.Makes.AddOrUpdate(
              new Models.Make() { makeAr = "„ÌÃ«‰", makeEn = "Megan" }
             );


            context.AuctionCompanies.AddOrUpdate(
            new Models.AuctionCompany() { CompanyNameEn = "Eimrates Auction", CompanyNameAr = "«·√„«—«  ··„“«œ« " }
            );

            context.AdditionalInfo.AddOrUpdate(
          new Models.AdditionalInfo()
          {
              bids = 37,
              currencyAr = "œ—Â„",
              currencyEn = "AED",
              currentPrice = 150000,
              endDate = 1234,
              endDateAr = DateTime.Now,
              endDateEn = DateTime.Now,
              iCarId = 1,
              isModified = 1,
              itemid = 345,
              iVinNumber = string.Empty,
              lot = 345,
              minIncrement = 1,
              priority = 1,
              VATPercent = 1

          }
         );


            context.AdditionalInfo.AddOrUpdate(
         new Models.AdditionalInfo()
         {
             bids = 20,
             currencyAr = "œ—Â„",
             currencyEn = "AED",
             currentPrice = 250000,
             endDate = 1234,
             endDateAr = DateTime.Now,
             endDateEn = DateTime.Now,
             iCarId = 1,
             isModified = 1,
             itemid = 345,
             iVinNumber = string.Empty,
             lot = 345,
             minIncrement = 1,
             priority = 1,
             VATPercent = 1

         }
        );

            context.Cars.AddOrUpdate(
       new Models.Car()
       {
           AdditionalInfoID = 1,
           CompanyID = 1,
           Description_Ar = "ssss",
           Description_En = "mmmm",
           imgCount = 1,
           modelID = 1,
           makeID = 1,
           bodyId = 1,
           year = 2015,
           mileage = "nnn",
           SharingLink = string.Empty,
           Image = "https://cdn.emiratesauction.com/media/9jeqvldvobggms4ko3qmdfpdqq0s12o81i3wid3o67xji1to3/t_,w_",




       }
      );

            context.Cars.AddOrUpdate(
      new Models.Car()
      {
          AdditionalInfoID = 2,
          CompanyID = 1,
          Description_Ar = "ssss",
          Description_En = "mmmm",
          imgCount = 1,
          modelID = 1,
          makeID = 1,
          bodyId = 1,
          year = 2015,
          mileage = "nnn",
          SharingLink = string.Empty,
          Image = "https://cdn.emiratesauction.com/media/9jeqvldvobggms4ko3qmdfpdqq0s12o81i3wid3o67xji1to3/t_,w_",




      }
     );

            context.Bodies.AddOrUpdate(
 new Models.Body()
 {
     bodyAr = "Â« ‘»«ﬂ",
     bodyEn = "Hatshback"



 }
);
            context.Bodies.AddOrUpdate(
new Models.Body()
{
    bodyAr = "”Ìœ«‰",
    bodyEn = "sedan"



});
        }

    }
}
