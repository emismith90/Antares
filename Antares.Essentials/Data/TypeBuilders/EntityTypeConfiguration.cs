using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.Entities;

namespace Antares.Essentials.Data.TypeBuilders
{
    public abstract class EntityTypeConfiguration<TEntity> : EntityTypeConfiguration<TEntity, int>
        where TEntity : EntityBase
    {
    }

    public abstract class EntityTypeConfiguration<TEntity, TEntityKey>
        where TEntity : EntityBase<TEntityKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
        }
    }
}
