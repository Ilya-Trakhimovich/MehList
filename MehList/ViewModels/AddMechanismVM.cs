using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MehList.ViewModels
{
    public class AddMechanismVM
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Fuel consumption (Use ',' as separator)")]
        public string FuelСonsumption { get; set; }
    }
}
