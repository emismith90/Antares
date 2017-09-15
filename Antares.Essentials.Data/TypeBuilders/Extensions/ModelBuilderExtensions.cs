using Microsoft.EntityFrameworkCore;
using Antares.Essentials.Data.Entities;
using Antares.Essentials.Data.TypeBuilders;

namespace Antares.Essentials.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, IEntityTypeConfiguration<TEntity> configuration)
            where TEntity : EntityBase
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity, TKey>(this ModelBuilder modelBuilder, IEntityTypeConfiguration<TEntity, TKey> configuration)
            where TEntity : EntityBase<TKey>
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, IAuditableTypeConfiguration<TEntity> configuration)
           where TEntity : AuditableEntityBase
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity, TKey>(this ModelBuilder modelBuilder, IAuditableTypeConfiguration<TEntity, TKey> configuration)
           where TEntity : AuditableEntityBase<TKey>
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }
    }
}
