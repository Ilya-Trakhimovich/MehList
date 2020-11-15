using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Entities
{
    public class BuildingObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractNumber { get; set; }
        public IEnumerable<Mechanism> Mechanisms { get; set; }

        public BuildingObject()
        {
            Mechanisms = new List<Mechanism>();
        }
    }
}
