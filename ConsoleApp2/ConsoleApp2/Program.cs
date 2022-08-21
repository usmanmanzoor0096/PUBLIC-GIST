using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input = { "john": 23, "james": 24, "vincent": 34, "louis": 29}
            //Sort by keys, and return array of values only.

            IDictionary<int, string> numberNames = new Dictionary<int, string>() { {  23, "john" } ,{ 24 , "james" },{  34, "vincent" }, {  29, "louis" } };

            var list = new List<ArraySort>();
            foreach (var item in numberNames)
            {
               var obj = new ArraySort{
                    Key = Convert.ToInt32(item.Key),
                    value = item.Value.ToString()
                };


                list.Add(obj);

            }
            var res = list.OrderBy(c => c.Key).ToList();
            //Console.WriteLine(numberNames.Keys)

            foreach (var item in res)
            {
                Console.WriteLine(item.value);
            }
       
        }

    }
    public class ArraySort {
        public int Key { get; set; }
        public string value { get; set; }
    }
}
