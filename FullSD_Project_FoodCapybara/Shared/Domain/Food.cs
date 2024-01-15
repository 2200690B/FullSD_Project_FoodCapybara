using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        public int RestId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public string? FoodName { get; set; }
        public int FoodRating { get; set; }
        public string? FoodDesc { get; set; }
        public decimal FoodCost { get; set; }
        
    }
}

/*
 * FoodID (PK)
RestID(FK)
FoodName
FoodRating
FoodDesc
FoodCost
*/