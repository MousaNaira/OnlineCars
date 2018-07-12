using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCars.Data.Models;

namespace OnlineCars.Services
{
    public class Service : IService
    {
        OnlineCarsContext _context = new Data.Models.OnlineCarsContext();
        public List<Car> GetAllCars()
        {
            List<Car> _list = (from X in _context.Cars select X).ToList();
            return _list;
        }

        public List<Car> FilterByName(string Name)
        {
            List<Car> _list = _context.Cars.Where(X => X.Model.modelAr.Contains(Name)).ToList();
            return _list;
        }

        public List<Car> GetMoreItems(int PageNumber )
        {
           // int PageCount = _context.Cars.Count();
            List<Car> _list = _context.Cars.OrderByDescending(c => c.CarID).Skip((PageNumber - 1) * 5).Take(5).ToList<Car>();
            return _list;

        }
    }
}
