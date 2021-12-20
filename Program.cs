using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            Users user1 = new Users() 
            { 
                ID=1,
                FirstName="FirstName1",
                LastName="LastName1",
                Sex=Gender.Male,
                Age=21
            };
            Users user2 = new Users()
            {
                ID = 2,
                FirstName = "FirstName2",
                LastName = "LastName2",
                Sex = Gender.Male,
                Age = 23
            };
            Users user3 = new Users()
            {
                ID = 3,
                FirstName = "FirstName3",
                LastName = "LastName3",
                Sex = Gender.Female,
                Age = 19
            };
            Users user4 = new Users()
            {
                ID = 4,
                FirstName = "FirstName4",
                LastName = "LastName4",
                Sex = Gender.Female,
                Age = 24
            };
            Users user5 = new Users()
            {
                ID = 5,
                FirstName = "FirstName5",
                LastName = "LastName5",
                Sex = Gender.Male,
                Age = 23
            };
            Users user6 = new Users()
            {
                ID = 6,
                FirstName = "FirstName6",
                LastName = "LastName6",
                Sex = Gender.Female,
                Age = 26
            };
            Users user7 = new Users()
            {
                ID = 7,
                FirstName = "FirstName7",
                LastName = "LastName7",
                Sex = Gender.Female,
                Age = 25
            };
            Users user8 = new Users()
            {
                ID = 8,
                FirstName = "FirstName8",
                LastName = "LastName8",
                Sex = Gender.Female,
                Age = 28
            };
            Users user9 = new Users()
            {
                ID = 9,
                FirstName = "FirstName9",
                LastName = "LastName9",
                Sex = Gender.Male,
                Age = 27
            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            users.Add(user6);
            users.Add(user7);
            users.Add(user8);
            users.Add(user9);
            Console.WriteLine("Where");
            var result = users.Where(u => u.Age >= 20).Select(s => new { s.FirstName, s.Age}).ToList();
            foreach (object ob in result)
            {
                Console.WriteLine(ob); 
            }
            Console.WriteLine("OrderBy");
            result = users.OrderBy(u => u.Age).Select(s => new { s.FirstName, s.Age }).ToList();
            foreach (object ob in result)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("OrderBy Descending");
            result = users.OrderByDescending(u => u.Age).Select(s => new { s.FirstName, s.Age }).ToList();
            foreach (object ob in result)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("OrderBy ThenBy");
            result = users.OrderBy(u => u.Age).ThenBy(u => u.FirstName).Select(s => new { s.FirstName, s.Age }).ToList();
            foreach (object ob in result)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine("OrderBy Thenbydescending");
            result = users.OrderBy(u => u.Age).ThenByDescending(u => u.FirstName).Select(s => new { s.FirstName, s.Age }).ToList();
            foreach (object ob in result)
            {
                Console.WriteLine(ob);
            }
            
        }
    }
}
