using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustId { get; set; }  //not needed but added to make it more explicit to know what id you are using
        public virtual Customer? Customer { get; set; } //acts as a constraint
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }   //'virtual' acts does Lazy Loading
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public virtual List<OrderItem>? OrderItems { get; set; }  //Order contains list of OrderItems
    }
}

/*
OrderID (PK)
CustID (FK)
StaffID(FK)
OrderPrice
OrderDate
OrderStatus
*/