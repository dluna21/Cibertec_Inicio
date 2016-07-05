using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    //Nota 1:
    // A los modelos se le pueden agregar Validaciones

    public class Client
    {   
        public int ID { get; set; }
        [Display(Name = "Client_Name",ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }
        [Display(Name = "Client_LastName",ResourceType =typeof(Resource))]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        [Display(Name = "Client_DateCreation", ResourceType = typeof(Resource))]
        [DataType(DataType.DateTime)]
        public DateTime DateRegistre { get; set; }
    }
}
