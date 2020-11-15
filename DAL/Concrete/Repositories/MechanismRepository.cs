using DAL.Abstract.IRepositories;
using DAL.EF.EFContext;
using DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete.Repositories
{
    public class MechanismRepository : IMechanismRepository
    {
        private readonly AppDbContext _context;

        public MechanismRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Mechanism item)
        {
            _context.Mechanisms.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Mechanism> GetItems()
        {
            return _context.Mechanisms.ToList();
        }
    }
}
