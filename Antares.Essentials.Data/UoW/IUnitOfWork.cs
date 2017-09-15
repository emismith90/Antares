using System;

namespace Antares.Essentials.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IUnitOfWork Commit();
        IUnitOfWork BeginTransaction();
        bool EndTransaction();
        void RollBack();
    }
}
