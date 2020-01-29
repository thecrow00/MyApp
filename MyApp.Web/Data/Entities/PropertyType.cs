﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory")] //Data Notations
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Property Type")]
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}
