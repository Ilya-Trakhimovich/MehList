using DAL.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IMechanismRepository MechanismRepository { get; }
        IBuildingObjectRepository BuildingObjectRepository { get; }
    }
}
