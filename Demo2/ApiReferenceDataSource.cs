using System;
using System.Collections.Generic;

namespace Demo2
{
    public abstract class ApiDataSource
    {
        public string Name = "API";
    }

    public class ApiReferenceDataSrouce : ApiDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code = "xyz", Description = "from API" },
                new ReferenceDataItem { Code = "xyz", Description = "from API 2" }
            };
        }
    }
}
