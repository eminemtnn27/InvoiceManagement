using InvoiceManagement.WebApi.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.DbOperations
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<CreditCard> _cards;
        public DbClient(IOptions<CreditCardDbConfig> creditCardDbConfig)
        {
            //var client = new MongoClient(creditCardDbConfig.Value.Connection_String);
            //var client = new MongoClient("mongodb://creditCard:RD6gYhxxGWPt3H8@cluster0.nmy6laf.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient("mongodb+srv://creditCard:RD6gYhxxGWPt3H8@cluster0.r5hg6ou.mongodb.net/?retryWrites=true&w=majority");
       // mongodb://username:password@ds011111.mongolab.com:11111/db-name?connect=replicaSet
            var database = client.GetDatabase(creditCardDbConfig.Value.Database_Name);
            _cards = database.GetCollection<CreditCard>(creditCardDbConfig.Value.CreditCard_Collection_Name);
        }

        public IMongoCollection<CreditCard> GetCreditCardsCollection()
        {
            return _cards;
        }
    }
}
