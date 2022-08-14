using BusinessLayer.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.ViewComponents.Flat
{
    public class CreditCardFlat:ViewComponent
    {
        PaymentManager pm = new PaymentManager(new EfPaymentDal());
        FlatManager hm = new FlatManager(new EfFlatDal()); 

        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetPaymentListWithHouse(id);

            return View(values);
        }
    }
}
