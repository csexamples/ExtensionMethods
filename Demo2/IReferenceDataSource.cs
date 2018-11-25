using System;
using System.Collections.Generic;

namespace Demo2
{
    public interface IReferenceDataSource
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}
