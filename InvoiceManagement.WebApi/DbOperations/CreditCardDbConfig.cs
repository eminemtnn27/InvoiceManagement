using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.WebApi.DbOperations
{
    public class CreditCardDbConfig
    {
        public string Database_Name { get; set; }
        public string CreditCard_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
