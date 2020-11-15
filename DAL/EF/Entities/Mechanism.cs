using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF.Entities
{
    public class Mechanism
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FuelConsumption { get; set; }
        public IEnumerable<BuildingObject> BuildingObjects { get; set; }

        public Mechanism()
        {
            BuildingObjects = new List<BuildingObject>();
        }
    }
}
