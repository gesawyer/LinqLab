using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {10, 2330, 112233, 10, 949, 3764, 2942 };

            List<int> odds = nums1.Where(x => x % 2 == 1).ToList();

            Console.WriteLine("1) Minimum number");
            int lowtNum = nums1.Min();
            Console.WriteLine(lowtNum);

            Console.WriteLine();
            Console.WriteLine("2) Maximum number");
            int highestNum = nums1.Max();
            Console.WriteLine(highestNum);

            Console.WriteLine();
            Console.WriteLine("3) Max number under 10000");
            int under10000 = nums1.Where(x=> x< 10000).Max();
            Console.WriteLine(under10000);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("4) All values between 10 and 100");
            List <int> btw10 = nums1.Where(x => x < 100 && x > 10).ToList();
            foreach (int num in btw10.ToList())
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("5) All values between 100000 and 999999");
            List<int> btw9 = nums1.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (int num in btw9.ToList())
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("6) Count even numbers.");
            int totalEvens = nums1.Where(x => x % 2 == 0).Count();
            Console.WriteLine(totalEvens);


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Linq with objects");
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13)); 
            students.Add(new Student("Hannah Banana", 21)); 
            students.Add(new Student("Justin", 30)); 
            students.Add(new Student("Sarah", 53)); 
            students.Add(new Student("Hannibal", 15)); 
            students.Add(new Student("Phillip", 16)); 
            students.Add(new Student("Maria", 63)); 
            students.Add(new Student("Abe", 33)); 
            students.Add(new Student("Curtis", 10));

            

            Console.WriteLine();
            Console.WriteLine("1) students that can drive.");
            List<Student> drinkers = students.Where(x => x.CanDrink == true).ToList();
            foreach (Student d in drinkers)
            {
                Console.WriteLine(d.Name);
            }

            Console.WriteLine("2)Find the oldest student");
            Student s = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine(s.Name);

            Console.WriteLine("3)Find the youngest student");
            Student w = students.OrderByDescending(x => x.Age).Last();
            Console.WriteLine(w.Name);

            Console.WriteLine("4)Find the oldest student under 25");
            List<Student> oldestUnder25 = students.Where(x => x.Age <25).ToList();
            Student q = oldestUnder25.OrderByDescending(x => x.Age).First();
            Console.WriteLine(q.Name);

            Console.WriteLine("5)Find the even aged over 21");
            List<Student> os5= students.Where(x => x.CanDrink && x.Age%2 == 0).ToList();
            foreach (Student d in os5)
            {
                Console.WriteLine(d.Name);
            }

            Console.WriteLine("6)Find all teenaged students");
            List<Student> s6 = students.Where(x => x.Age >=13 && x.Age <= 19).ToList();
            foreach (Student d in s6)
            {
                Console.WriteLine(d.Name);
            }


            //var vowelsStart = students.Where(x => Student.Any(vowel=> x.StartsWith(vowel)));
            
            Console.WriteLine("7) Find all students whos names start with a vowel");
            char[] vowel = "aeiou".ToCharArray();
            var queryResults=
                from n in students
                //where n.StartsWith(vowel)
                select n;
            foreach (var item in queryResults)
            {
                Console.WriteLine(item);
            }













        }
    }
}
