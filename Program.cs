using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Emplyee { id = 1, name = "yousif ",  age=26};
            var emp2 = new Emplyee { id = 2, name = "hous ",  age=36};
            var emp3 = new Emplyee { id = 3, name = "ali ",  age=39};
            var emp4 = new Emplyee { id = 4, name = "alk ",  age=39};

            Emplyee[] empArray =
            {
                emp, emp2, emp3 ,emp4
            };

            List<Emplyee> empList = new List<Emplyee>(5);

            //empList.Add(emp);
            // empList.AddRange(empArray);
            List<Emplyee> empList3 = new List<Emplyee>(empArray);

           // empList.Insert(1, new Emplyee { id = 1, name = "aaaa ", age = 30 });
            var count=empList.Count;
            var capcity = empList.Capacity;
            Console.WriteLine(count);
            Console.WriteLine(capcity);

             foreach (Emplyee emplyee in empList3)
            {
                Console.WriteLine(emplyee.name);
            }

            // empList3.RemoveAll(x=>x.name.EndsWith("us"));
            empList3.RemoveAll(x => x.name.StartsWith("you"));

            Console.WriteLine("==========================");
            foreach (Emplyee emplyee in empList3)
            {
                Console.WriteLine(emplyee.name);
            }
            Console.ReadKey(); 

        }
    }
}
 