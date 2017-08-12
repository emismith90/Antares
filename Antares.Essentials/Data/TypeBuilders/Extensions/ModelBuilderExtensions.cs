using Microsoft.EntityFrameworkCore;
using Antares.Essentials.Data.Entities;
using Antares.Essentials.Data.TypeBuilders;

namespace Antares.Essentials.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
            where TEntity : EntityBase
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity, TKey>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity, TKey> configuration)
            where TEntity : EntityBase<TKey>
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, AuditableTypeConfiguration<TEntity> configuration)
           where TEntity : AuditableEntityBase
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }

        public static void AddConfiguration<TEntity, TKey>(this ModelBuilder modelBuilder, AuditableTypeConfiguration<TEntity, TKey> configuration)
           where TEntity : AuditableEntityBase<TKey>
        {
            configuration.Configure(modelBuilder.Entity<TEntity>());
        }
    }
}
