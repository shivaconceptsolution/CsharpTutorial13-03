using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LinqToCollection
    {
        class Student
        {
              internal int rno;
              internal String sname;
              internal string branch;
              internal int fees;
            
            
        }
        static void Main()
        {
            List<Student> stu = new List<Student>();
            stu.Add(new Student() { rno = 1001, sname = "xyz123", branch = "CS", fees = 22000 });
            stu.Add(new Student() { rno = 1001,sname="xyz",branch="CS",fees=82000 });
            stu.Add(new Student() { rno = 1003, sname = "mno", branch = "CS", fees = 32000 });
            stu.Add(new Student() { rno = 1002, sname = "abc123", branch = "IT", fees = 120000 });
            stu.Add(new Student() { rno = 1004, sname = "abc124", branch = "EC", fees = 450000 });
        //    var s = from c in stu where c.fees>=50000 && (c.rno==1001 || c.rno==1003)   select c;
       //var s = from c in stu where c.fees >= 50000 && c.fees <= 100000 select c;
       //   var s = stu.Where(c => c.fees >= 50000 && c.fees <= 100000);
         //   var fee = stu.OrderByDescending(a => a.fees).Skip(1).Take(1).SingleOrDefault();
           // Console.WriteLine(fee.fees);
           // var s = from c in stu where c.fees ==fee.fees  select c;
          //  var s =(from c in stu select c.fees).Max();
            //Console.WriteLine(s);
            //var s2 = from c2 in stu where c2.fees==((from c1 in stu where c1.fees < ((from c in stu select c.fees).Max()) select c1.fees).Max()) select c2;
            var s = stu.Max(c => c.fees);
            var s2 =stu.Where(k=>k.fees==(stu.Where(c=>c.fees<s).Max(c=>c.fees)));
            
            foreach (Student s1 in s2)
            {
                Console.WriteLine(s1.rno + " ," + s1.sname + " ," + s1.branch + " ," + s1.fees);
            }
            Console.ReadKey();
        }
    }
}
