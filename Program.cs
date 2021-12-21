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

            List<Users> newUsers = new List<Users>();
            Users user10 = new Users()
            {
                ID = 10,
                FirstName = "FirstName10",
                LastName = "LastName10",
                Sex = Gender.Female,
                Age = 26
            };
            Users user11 = new Users()
            {
                ID = 11,
                FirstName = "FirstName11",
                LastName = "LastName11",
                Sex = Gender.Female,
                Age = 25
            };
            Users user12 = new Users()
            {
                ID = 12,
                FirstName = "FirstName12",
                LastName = "LastName12",
                Sex = Gender.Female,
                Age = 28
            };
            Users user13 = new Users()
            {
                ID = 13,
                FirstName = "FirstName13",
                LastName = "LastName9",
                Sex = Gender.Male,
                Age = 27
            };
            newUsers.Add(user10);
            newUsers.Add(user11);
            newUsers.Add(user12);
            newUsers.Add(user13);

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


            Orders order1 = new Orders()
            {
                Id = 1,
                UserId = 1,
                Name = "Product1"
            };
            Orders order2 = new Orders()
            {
                Id = 2,
                UserId = 3,
                Name = "Product1"

            };
            Orders order3 = new Orders()
            {
                Id = 3,
                UserId = 2,
                Name = "Product1"
            };
            Orders order4 = new Orders()
            {
                Id = 4,
                UserId = 4,
                Name = "Product4"
            };
            Orders order5 = new Orders()
            {
                Id = 5,
                UserId = 1,
                Name = "Product5"
            };
            Orders order6 = new Orders()
            {
                Id = 6,
                UserId = 2,
                Name = "Product6"
            };
            List<Orders> orders = new List<Orders>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);
            orders.Add(order5);
            orders.Add(order6);
            var innerJoin = orders.Join(users, o => o.UserId, s => s.ID, (o, s) =>( o.Id,o.UserId, o.Name)).ToList();
            Console.WriteLine("innerjoin");
            foreach (object ob in innerJoin)
            {
                Console.WriteLine(ob);
            }

            bool isAllAdult = users.All(u => u.Age >= 18);
            Console.WriteLine("are all users adult:{0}",isAllAdult);

            bool isAnyTeen = users.All(u => u.Age <= 18);
            Console.WriteLine("Is any users teen:{0}", isAnyTeen);

            Users u = new Users()
            {
                ID = 6,
                FirstName = "FirstName6",
                LastName = "LastName6",
                Sex = Gender.Female,
                Age = 26 
            };
            bool isContains = users.Contains(u);
            Console.WriteLine("is user present:{0}", isContains);

            Users results = users.ElementAt(5);
            Console.WriteLine("{0},{1},{2},{3}",results.ID,results.FirstName,results.LastName,results.Sex);

            results = users.ElementAtOrDefault(10);
            Console.WriteLine(results);


            results = users.First(s=>s.ID == 5);
            Console.WriteLine(results.FirstName);

            results = users.FirstOrDefault(s=>s.ID==10);
            Console.WriteLine(results);

            results = users.Single(s => s.Age == 19);
            Console.WriteLine(results.FirstName);

            results = users.SingleOrDefault(s => s.Age == 27);
            Console.WriteLine(results.FirstName);

            results = users.Last();
            Console.WriteLine(results.FirstName);

            results = users.LastOrDefault();
            Console.WriteLine(results.FirstName);

            /*   results = users.Concat(newUsers).ToList();

               Console.WriteLine(results);*/
            List<int> list1 = new List<int>() { 1,2,3,4,5,6,7,8};
            List<int> list2 = new List<int>() { 2,3,5,6,8,3,9,0,10 };
            List<int> finalList = new List<int>();
            Console.WriteLine("concat");
            finalList = list1.Concat(list2).ToList();
            foreach (int element in finalList) 
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("distinct");
            finalList = list1.Distinct().ToList();
            foreach (int element in finalList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("except");
            finalList = list1.Except(list2).ToList();
            foreach (int element in finalList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("union");
            finalList = list1.Union(list2).ToList();
            foreach (int element in finalList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("intersect");
            finalList = list1.Intersect(list2).ToList();
            foreach (int element in finalList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
    