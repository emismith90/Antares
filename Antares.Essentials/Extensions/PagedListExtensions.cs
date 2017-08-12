﻿using System.Collections.Generic;
using Antares.Essentials.Helpers;

namespace Antares.Essentials.Extensions
{
    public static class PagedListExtensions
    {
        public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> superset, int pageNumber, int pageSize)
        {
            return new PagedList<T>(superset, pageNumber, pageSize);
        }
    }
}
