using System.Collections.Generic;
using Antares.Essentials.Utilities;

namespace Antares.Essentials.Application.Services
{
    public interface IContentListingService<TModel>
    {
        IList<TModel> GetAll();
        IPagedList<TModel> GetAll(int pageNumber, int pageSize);
    }
}
