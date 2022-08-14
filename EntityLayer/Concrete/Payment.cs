using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal BillingSum { get; set; }
        public DateTime BillingDate { get; set; }
        public bool IsPaid { get; set; }

        public int FlatId { get; set; }
        public Flat flat { get; set; }
    }
}
