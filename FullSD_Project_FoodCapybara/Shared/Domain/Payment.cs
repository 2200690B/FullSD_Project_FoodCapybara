using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public decimal PaymentTotal { get; set; }
    }
}

/*PaymentID (PK)
OrderID (FK)
PaymentMethod
PaymtentDateTime
PaymentTotal
*/