using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Antares.Essentials.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
        public IUnitOfWork BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
            return this;
        }

        public IUnitOfWork Commit()
        {
            _context.SaveChanges();
            return this;
        }

        public bool EndTransaction()
        {
            _context.SaveChanges();
            _transaction.Commit();

            return true;
        }

        public void RollBack()
        {
            _transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
