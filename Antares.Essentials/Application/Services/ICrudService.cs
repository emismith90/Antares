using Antares.Essentials.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antares.Essentials.Application.Services
{
    public interface ICrudService<TModel> : ICrudService<TModel, int>
       where TModel : ModelBase
    {
    }

    public interface ICrudService<TModel, TKey> 
        where TModel : ModelBase<TKey>
    {
        TModel GetById(TKey id);
        bool Add(TModel todo);
        bool Update(TModel todo);
        bool Remove(TKey id);
    }
}
