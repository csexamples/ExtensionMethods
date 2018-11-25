using System;
using System.Collections.Generic;

namespace Demo2
{
    public abstract class XmlDataSource
    {
        public string Name = "XML";
    }

    public class XmlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
        {
            new ReferenceDataItem { Code = "xyz", Description = "from XML" },
            new ReferenceDataItem { Code = "xyz", Description = "from XML 2" }
        };
        }
    }
}
