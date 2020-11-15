using DAL.Abstract.IRepositories;
using DAL.Abstract.IUnitOfWork;
using DAL.Concrete.Repositories;
using DAL.EF.EFContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IMechanismRepository MechanismRepository => new MechanismRepository(_context);

        public IBuildingObjectRepository BuildingObjectRepository => new BuildingObjectRepository(_context);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
