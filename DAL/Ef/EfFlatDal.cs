using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfFlatDal : GenericRepository<Flat>, IFlatDal
    {        
        public List<Flat> GetLoggedUserHouse(int id)
        {
            using (var c = new AllDbContext())
            {
                return c.flats.Where(x => x.User.UserId == id).ToList();
            }
        }
    }
}
