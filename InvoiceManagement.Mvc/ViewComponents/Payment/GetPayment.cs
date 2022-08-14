using BusinessLayer.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.ViewComponents.Payment
{
    public class GetPayment : ViewComponent
    {
        PaymentManager pm = new PaymentManager(new EfPaymentDal());
        public IViewComponentResult Invoke(int id)
        {
            var result = pm.GetPaymentWithHouse(id);
            decimal _sum = decimal.Parse(result.BillingSum.ToString()) + decimal.Parse(result.flat.FlatNo.ToString());
            ViewBag.sum = _sum;
            Value.sum = _sum;
            Value.paymentId = id;
            return View(result);
        }

        public static class Value
        {
            public static decimal sum;
            public static int paymentId;
        }
    }
}
