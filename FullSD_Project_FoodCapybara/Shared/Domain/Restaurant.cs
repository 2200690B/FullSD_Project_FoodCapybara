using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string? RestName { get; set; }
        public string? RestAddress { get; set;}
        public string? RestDescription { get; set; }
        public string? RestCategory { get; set; }
        //public string? RestImage { get; set; }  
        public string? ImageUrl {  get; set; }
        public string? FileName { get; set; }
        public byte[]? FileContent { get; set; }
        public virtual ICollection<Food>? Menu { get; set; } //each restaurant contains a list of foods(menu)
    }
}

/*
 * RestID (PK)
RestName
RestAddress
RestDescription
RestCategory
*/