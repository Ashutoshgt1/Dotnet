using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet3_list_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string> { "apple", "banana", "cherry" };
            items.Add("date");
            items.AddRange(new[] { "blueberry", "fig" });
            items.Insert(2, "orange");
            Console.WriteLine("list: "+string.Join(",", items));

            items[1] = "blackberry";
            bool hascherry = items.Contains("cherry");
            Console.WriteLine(hascherry);

            int idv = items.IndexOf("fig");
            Console.WriteLine(idv);

            int lastidx = items.LastIndexOf("fig");
            Console.WriteLine(lastidx);

            var withE = items.FindAll(s => s.Contains("e"));
            Console.WriteLine("with E: " + string.Join(", ", withE));

            items.Sort();
            Console.WriteLine("Sorted: " + string.Join(", ", items));

            items.Reverse();
            Console.WriteLine("Reverse: " + string.Join(", ", items));

            items.Remove("orange");
            Console.WriteLine("removed orange: " + string.Join(", ", items));
            var copy = new List<string>(items);
            Console.WriteLine(" copy: " + string.Join(", ", items));

            items.Clear();
            Console.WriteLine(" after clear: " + string.Join(", ", items));

        }
    }
}
