using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public virtual ICollection<BookCustomer> bookCustomers { get; set; }
    }
}
