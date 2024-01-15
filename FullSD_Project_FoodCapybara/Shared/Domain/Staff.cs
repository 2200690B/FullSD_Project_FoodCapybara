using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }
        public string? StaffUsername { get; set; }
        public string? StaffPassword { get; set; }
        public string? StaffEmail { get; set; }
        public int StaffPhone { get; set; }
        public string? StaffPosition { get; set; }
        public bool? IsAdmin { get; set; }

    }
}


/*StaffID (PK)
StaffUsername
StaffPassword
StaffEmail
StaffPhone
StaffPosition
StaffIsAdmin
*/