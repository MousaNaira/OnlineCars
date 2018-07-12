using OnlineCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCars.Services
{
    public interface IService
    {
         List<Car>  GetAllCars();
         List<Car> FilterByName(string Name);

        List<Car> GetMoreItems(int PageNumber);
         
    }
}
