using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.Entities;

namespace Antares.Essentials.Data.TypeBuilders
{
    public interface IEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity, int>
        where TEntity : EntityBase
    {
    }

    public interface IEntityTypeConfiguration<TEntity, TEntityKey>
        where TEntity : EntityBase<TEntityKey>
    {
        void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
