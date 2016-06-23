using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    //Nota 1:
    // A los modelos se le pueden agregar Validaciones

    public class Client
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime DateRegistre { get; set; }
    }
}
