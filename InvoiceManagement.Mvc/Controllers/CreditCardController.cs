using BusinessLayer.Concrete;
using InvoiceManagement.WebApi.Application.CreditCardOperations.Commands.CreateCreditCardCommand;
using DAL.Ef;
using DAL.EntityFramework;
using InvoiceManagement.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static InvoiceManagement.WebApi.ViewComponents.Payment.GetPayment;
using InvoiceManagement.WebApi.Entities;

namespace InvoiceManagement.WebApi.Controllers
{
    public class CreditCardApiController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        PaymentManager pm = new PaymentManager(new EfPaymentDal());
        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreditCard p)
        {
            var usermail = User.Identity.Name;
            var uservalue = um.getLoggedUser(usermail);
            int idUser = uservalue.UserId;
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44350/CreditCards/" + idUser);
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<CreditCard>(jsonString);

            var sum = Value.sum;
            int id = Value.paymentId;

            if (p.CardNumber == values.CardNumber && decimal.Parse(values.Balance.ToString()) >= sum && p.ExpireDate == values.ExpireDate && p.CVC == values.CVC)
            {
                values.Balance = values.Balance - sum;
                var pay = pm.GetPaymentWithHouse(id);
                pay.BillingSum = 0;
                pay.IsPaid = true;
                pm.TUpdate(pay);


                var jsonCard = JsonConvert.SerializeObject(values);
                var content = new StringContent(jsonCard, Encoding.UTF8, "application/json");
                var responseMessage2 = await httpClient.PutAsync("https://localhost:44350/CreditCards/", content);
                if (responseMessage2.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }


            }
            else
            {
                return View();
            }


        }


    }

}
