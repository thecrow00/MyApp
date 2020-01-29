using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Web.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Neighborhood*")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Address*")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Price*")]
        [DisplayFormat(DataFormatString = "{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Square meters*")]
        public string SquareMeters { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Rooms*")]
        public int Rooms { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Stratum")]
        public int Stratum { get; set; }

        [Display(Name = "Has Parking Lot?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        public string Remarks { get; set; }

        //relaciones
        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
