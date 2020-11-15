using DAL.Abstract.IRepositories;
using DAL.EF.EFContext;
using DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete.Repositories
{
    public class BuildingObjectRepository : IBuildingObjectRepository
    {
        private readonly AppDbContext _context;

        public BuildingObjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(BuildingObject item)
        {
            _context.BuildingObjects.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<BuildingObject> GetItems()
        {
            return _context.BuildingObjects.ToList();
        }
    }
}
