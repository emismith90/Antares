using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Antares.Essentials.Data.Entities
{
    public abstract class AuditableEntityBase : AuditableEntityBase<int>, IAuditableEntity, IEntity
    {
    }

    public abstract class AuditableEntityBase<T> : EntityBase<T>, IAuditableEntity, IEntity<T>
    {
        public string CreatedById { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string ModifiedById { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual IdentityUser CreatedBy { get; set; }
        public virtual IdentityUser ModifiedBy { get; set; }
    }
}
