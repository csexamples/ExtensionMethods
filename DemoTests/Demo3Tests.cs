using System;
using Xunit;
using Demo3;
using System.Reflection;

namespace DemoTests
{
    public class Demo3Tests
    {
        [Fact]
        public void Class1()
        {
            var obj = new Class1();

            Assert.Equal("a", obj.GetString1());
            Assert.Equal("A", obj.GetString1Upper());
        }

        [Fact]
        public void Class2()
        {
            var obj = new Class1.Class2();

            Assert.Equal("b", obj.GetString2());
            Assert.Equal("B", obj.GetString2Upper());
        }

        [Fact]
        public void Class3()
        {
            var type = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            var methodInfo = type.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj = Activator.CreateInstance(type);

            Assert.Equal("c", methodInfo.Invoke(obj, null));
            Assert.Equal("C", obj.GetString3Upper());
        }
    }
}
