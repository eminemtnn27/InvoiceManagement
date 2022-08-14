using InvoiceManagement.WebApi.Application.CreditCardOperations.Commands.CreateCreditCardCommand; 
using InvoiceManagement.WebApi.Entities; 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceManagement.WebApi.DbOperations;
using CreditCardApi.Application.CreditCardOperations;
using MongoDB.Driver.Linq;

namespace CreditCardApi.Controllers
{

    [ApiController]
    [Route("[controller]s")]
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService _cardService; 
        public CreditCardController(ICreditCardService cardService )
        {
            _cardService = cardService; 
        }

        [HttpGet]
        public IActionResult GetCards()
        {
            List <CreditCard> FakeCard()
            {
                return new List<CreditCard>()
            {
                new CreditCard()
                {
                    CardId="324567489795763",
                    CardNumber="3245894567628745",
                    CVC="111",
                    UserId=1,
                    Balance=0,
                    ExpireDate=DateTime.UtcNow.ToLongDateString()
                }
            }.ToList() ;
            }
            return Ok();
        }
        //[HttpGet("{id}", Name = "GetCard")]
        //public IActionResult GetCard(string id)
        //{
        //    return Ok(_cardService.GetCard(id));
        //}

        [HttpPost]
        public IActionResult AddCreditCard(CreditCard card)
        {
            _cardService.AddCreditCard(card);
            return CreatedAtRoute("GetCards", new { id = card.CardId }, card);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCard(string id)
        {
            _cardService.DeleteCard(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateCard(CreditCard card)
        {
            return Ok(_cardService.UpdateCard(card));
        }

        [HttpGet("{id}")]
        public IActionResult GetUserCard(int id)
        {
            return Ok(_cardService.GetUserCard(id));
        }
    }
}
