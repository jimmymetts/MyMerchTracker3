using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMerchTracker3.Models
{
    public class MerchType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [RegularExpression("^[a-zA-Z0-9 ]*$")]
        [StringLength(55, ErrorMessage = "Please shorten the product title to 55 characters")]
        public string Title { get; set; }

        public ICollection<Merch> Merchs { get; set; }
    }
}

