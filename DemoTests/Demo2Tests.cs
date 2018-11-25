using System;
using System.Collections.Generic;
using System.Linq;
using Demo2;
using Xunit;

namespace DemoTests
{
    public class Demo2Tests
    {
        [Fact]
        public void GetItems()
        {
            IReferenceDataSource source;

            source = new ApiReferenceDataSrouce();
            Assert.Equal(2, source.GetItems().Count());

            source = new SqlReferenceDataSource();
            Assert.Equal(2, source.GetItems().Count());

            source = new XmlReferenceDataSource();
            Assert.Equal(2, source.GetItems().Count());
        }

        [Fact]
        public void GetItemsByCode_Api()
        {
            var source = new ApiReferenceDataSrouce();

            Assert.Equal(2, source.GetItemsByCode("xyz").Count());
        }

        [Fact]
        public void GetItemsByCode_Sql()
        {
            var source = new SqlReferenceDataSource();

            Assert.Equal(2, source.GetItemsByCode("xyz").Count());
        }

        [Fact]
        public void GetItemsByCode_Xml()
        {
            var source = new XmlReferenceDataSource();

            Assert.Equal(2, source.GetItemsByCode("xyz").Count());
        }

        [Fact]
        public void GetAllItemsByCode()
        {
            var sources = new List<IReferenceDataSource>
            {
                new ApiReferenceDataSrouce(),
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource()
            };

            Assert.Equal(6, sources.GetAllitemsByCode("xyz").Count());
        }
    }
}
