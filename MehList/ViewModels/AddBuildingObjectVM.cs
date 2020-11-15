using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MehList.ViewModels
{
    public class AddBuildingObjectVM
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string ContractNumber { get; set; }
    }
}
