using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSD_Project_FoodCapybara.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requirements")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string? LastName { get; set; }
        public string? CustAddress { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not a valid email")]
        [EmailAddress]
        public string? CustEmail{ get; set;}
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Phone Number is not a valid phone number")]
        public string? CustPhone { get; set;}
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