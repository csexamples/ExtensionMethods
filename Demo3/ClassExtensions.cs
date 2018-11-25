using System;
using System.Reflection;

namespace Demo3
{
    public static class ClassExtensions
    {
        public static string GetString1Upper(this Class1 obj)
        {
            return obj.GetString1().ToUpper();
        }

        public static string GetString2Upper(this Class1.Class2 obj)
        {
            return obj.GetString2().ToUpper();
        }

        public static string GetString3Upper(this object obj)
        {
            var upper = string.Empty;
            var type = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);

            if (obj.GetType() == type)
            {
                var method = type.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
                var str = method.Invoke(obj, null) as string;

                upper = str.ToUpper();
            }

            return upper;
        }
    }
}
