using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.Entities;

namespace Antares.Essentials.Data.TypeBuilders
{
    public interface IAuditableTypeConfiguration<TEntity> : IAuditableTypeConfiguration<TEntity, int>
        where TEntity : AuditableEntityBase
    {
    }

    public interface IAuditableTypeConfiguration<TEntity, TEntityKey> : IEntityTypeConfiguration<TEntity, TEntityKey>
        where TEntity : AuditableEntityBase<TEntityKey>
    {
    }
}
