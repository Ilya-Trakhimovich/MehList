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
            throw new NotImplementedException();
        }

        public IEnumerable<BuildingObject> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
