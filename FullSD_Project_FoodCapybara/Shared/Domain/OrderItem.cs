using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
        public int FoodID { get; set; }
        public virtual Food? Food{ get; set; }
        public int OIQuantity { get; set; }
    }
}

/*
 * OrderItemID (PK)
OrderID (FK)
FoodID (FK)
OIQuantity
*/