using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehList.ViewModels
{
    public class IndexVM
    {
        public List<MechanismVM> Mechanisms { get; set; }
        public List<BuildingObjectVM> BuildingObjects { get; set; }

        public IndexVM()
        {
            Mechanisms = new List<MechanismVM>();
            BuildingObjects = new List<BuildingObjectVM>();
        }
    }
}
