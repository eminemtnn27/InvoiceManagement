using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;  
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete; 

namespace DAL.EntityFramework
{
    public class EfPaymentDal : GenericRepository<Payment>, IPaymentDal
    {
        public List<Payment> GetPaymentListWithHouse()
        {
            using (var c = new AllDbContext())
            {
                return c.Payments.Include(x => x.flat).ToList();
            }
        }

        public List<Payment> GetPaymentListWithHouse(int id)
        {
            using (var c = new AllDbContext())
            {
                return c.Payments.Include(x => x.flat).Where(x => x.flat.FlatId == id && x.IsPaid == false).ToList();
            }
        }

        public Payment GetPaymentWithHouse(int id)
        {
            using (var c = new AllDbContext())
            {
                return c.Payments.Include(x => x.flat).Where(x => x.PaymentId == id && x.IsPaid == false).FirstOrDefault();
            }
        }
    }
}
