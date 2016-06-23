using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "The Code is required")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Price Sale")]
        [Required(ErrorMessage = "The Price Sale is required")]
        public float PriceSale { get; set; }

        [Display(Name = "Cost Sale")]
        [Required(ErrorMessage = "The Cost Sale is required")]
        public float PriceCost { get; set; }

        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Display(Name = "Date Expiration")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateExpiration { get; set; } = DateTime.Now;

        [Display(Name = "Date Register")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Editable(false)]
        public DateTime? DateRegister { get; set; } = DateTime.Now;

        [Display(Name = "Active")]
        public bool Active { get; set; } = true;
    }
}
