using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public string BookDescription { get; set; }
        public string BookLanguage { get; set; }
        public string BookPublisher { get; set; }
        public DateTime PublicationDate { get; set; }
        [Required]
        [StringLength(13)]
        public string BookISBN { get; set; }
        public string BookCoverImage { get; set; }
        public string BookFormat { get; set; }
        public int NoOfPages { get; set; }
        public DateTime StartDateLending { get; set; }
        public DateTime EndDateLending { get; set; }
        public bool BookIsCheckedOut { get; set; }
        public virtual ICollection<BookCustomer> bookCustomers { get; set; }
    }
}
