using System;

namespace Demo3
{
    public class Class1
    {
        public string GetString1()
        {
            return "a";
        }

        public class Class2
        {
            public string GetString2()
            {
                return "b";
            }

            private class Class3
            {
                private string GetString3()
                {
                    return "c";
                }
            }
        }
    }
}
