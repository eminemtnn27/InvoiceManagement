using DAL.Abstract;
using DAL.Concrete; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new AllDbContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new AllDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new AllDbContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new AllDbContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new AllDbContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
