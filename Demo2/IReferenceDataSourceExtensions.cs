using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2
{
    public static class IReferenceDataSourceExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetItemsByCode(this IReferenceDataSource source, string code)
        {
            return source.GetItems().Where(i => i.Code == code);
        }
    }
}
