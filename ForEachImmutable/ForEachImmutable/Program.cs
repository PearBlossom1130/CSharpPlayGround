using System;

namespace ForEachImmutable
{
    class Program
    {
        static void Main(string[] args)
        {

            var d = new Test[3];
            d[0] = new Test()
            {
                Age = 10,
                Name = "Test1"
            };
            d[1] = new Test()
            {
                Age = 11,
                Name = "Test2"
            };
            d[2] = new Test()
            {
                Age = 12,
                Name = "Test3"
            };

            //When using foreach on a list of objects, is the iterated object editable?
            // The object instance is NOT editable
            // But the object properties are editable
            
            //foreach (var d1 in d)
            //{
            //    d1 = new Test();
            //    Foreach iteration variable 'd1' is immutable.
            //}

            foreach (var d1 in d)
            {
                d1.Name = "TestAll";
            }


            foreach (var d1 in d)
            {
                Console.WriteLine($"{d1.Age} {d1.Name}");
            }


            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Test() {Age = 100, Name = "1000"};
            }
            
            foreach (var d1 in d)
            {
                Console.WriteLine($"{d1.Age} {d1.Name}");
            }


        }
    }

    class Test {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
