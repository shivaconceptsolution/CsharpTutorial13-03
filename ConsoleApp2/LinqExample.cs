using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LinqExample
    {
        static void Main()
        {

            string[] arr = { "hellosss", "welcome", "jay","klmnkkk","plhnop" };
         //    var s = from c in arr where c.Length > 5 select c;
         //   var s = from c in arr where c.Contains("e") select c;
          //  var s = from c in arr where c.StartsWith("w") select c;
           //   var s = from c in arr select c;
          //  var s = arr.Where(a => a.Length > 5);
          //  var s = arr.Where(a => a.Length > 5 && a.StartsWith("w"));
           // var s = (from c in arr select c).Take(2);
          //  var s = (from c in arr select c).Skip(1).Take(1);
          //  var s = (from c in arr select c).TakeWhile(a => a.Length > 5);
         //   var s = arr.TakeWhile(a => a.Length > 5);
          //  var s = (from c in arr select c).First();
          //  var s = (from c in arr select c).Last();
          //   var s = arr.Last(a=>a.Length>2).OrderBy(a=>a).Skip(1).Take(3);
              int [] arr1 = {12,23,31,78,89};
              int[] arr2 = { 11, 23, 31, 78, 33 };
              //var s = arr1.Union(arr2); 
             //  var s = arr1.Concat(arr2);
            //  var s = arr1
           //   var s = arr1.Except(arr2);.Intersect(arr2);
             var s = arr1.Reverse().Skip(1).Take(1);
            
            foreach (Object o in s)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();


        }
    }
}
