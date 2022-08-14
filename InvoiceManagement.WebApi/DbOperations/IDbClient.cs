using InvoiceManagement.WebApi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.DbOperations
{
    public interface IDbClient
    {
        IMongoCollection<CreditCard> GetCreditCardsCollection();
    }
}
