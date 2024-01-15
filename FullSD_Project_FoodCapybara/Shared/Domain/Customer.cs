using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string? CustUsername { get; set; }
        public string? CustPassword { get; set; }
        public string? CustAddress { get; set; }
        public string? CustEmail{ get; set;}
        public int CustPhone { get; set;}
        public decimal CustPayment { get; set; }
        public virtual List<Order>? CustOrderHistory { get; set; }
    }
}

/*CustID (PK)
CustUsername
CustPassword
CustAddress
CustEmail
CustPhone
CustPayment
CustOrderHistory
*/