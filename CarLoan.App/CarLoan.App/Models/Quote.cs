using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarLoan.App.Models
{
    public class Quote
    {
        [Key]
        public int quoteID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public decimal amount { get; set; }
        [Required]
        public DateTime createdOn { get; set; }
        public DateTime DeletedOn { get; set; }
    }

    public class QuoteViewModel
    {
        public int QuoteID { get; set; }
        public List<Quote> QuoteList { get; set; }
        public Quote Quote { get; set; }
    }
}
