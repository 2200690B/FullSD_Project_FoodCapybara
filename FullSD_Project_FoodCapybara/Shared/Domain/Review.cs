using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
        public int ReviewRating { get; set; }
        public string? ReviewOnRestFoods { get; set; }
        public DateTime ReviewDateTime { get; set; }
    }
}

/*
 * ReviewID (PK)
OrderID (FK)
ReviewRating
ReviewOnRestFoods
ReviewDateTime
*/