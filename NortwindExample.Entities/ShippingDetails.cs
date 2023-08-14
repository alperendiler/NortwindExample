 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="İsim Girilmesi Zorunludur")]
        [Display(Name = "Ad Soyad")]
        public String Name { get; set; }
        [Required()]
        [MinLength(10)]
        [MaxLength(50)]
        public String Address1 { get; set; }
        [MaxLength(50)]
        public String Address2 { get; set; }
        [MaxLength(50)]
        public String Address3 { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String Country { get; set; }
        [Required]
        public bool IsGift { get; set; }


    }
}
