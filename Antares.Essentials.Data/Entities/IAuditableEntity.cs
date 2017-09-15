using System;

namespace Antares.Essentials.Data.Entities
{
    public interface IAuditableEntity
    {
        string CreatedById { get; set; }
        DateTime? CreatedOn { get; set; }

        string ModifiedById { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}
