using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Antares.Essentials.Data.Entities;

namespace Antares.Essentials.Data.TypeBuilders
{
    public abstract class AuditableTypeConfiguration<TEntity> : AuditableTypeConfiguration<TEntity, int>
        where TEntity : AuditableEntityBase
    {
    }

    public abstract class AuditableTypeConfiguration<TEntity, TEntityKey> : EntityTypeConfiguration<TEntity, TEntityKey>
        where TEntity : AuditableEntityBase<TEntityKey>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.CreatedOn)
               .HasColumnType("datetime")
               .ValueGeneratedOnAdd();
            builder.Property(c => c.ModifiedOn)
               .HasColumnType("datetime")
               .ValueGeneratedOnAddOrUpdate();

            builder.HasOne(m => m.CreatedBy)
               .WithMany()
               .HasForeignKey(m => m.CreatedById);
            builder.HasOne(m => m.ModifiedBy)
               .WithMany()
               .HasForeignKey(m => m.ModifiedById);
        }
    }
}
