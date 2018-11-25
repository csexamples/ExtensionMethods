using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2
{
    public static class IReferenceDataSourceCollectionExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetAllitemsByCode(this IEnumerable<IReferenceDataSource> source, string code)
        {
            return source.SelectMany(r => r.GetItemsByCode(code));
        }
    }
}
