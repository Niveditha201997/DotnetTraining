using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","deLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };

       // 1.	write linq statement for people with last name that starts with the letter D

       // var people1 = people.Where(x => x.LastName.StartsWith("D"));
        var result = from Person in people
                     where  Person.LastName.StartsWith('D'+"")
                     select Person; 
        foreach(var person in result)
        {
            Console.WriteLine(person.LastName); 
        }

        // 2.	write a linq statement for people with last names that starts with the letter D and displays the count.

        var result1 = (from Person in people
                       where Person.LastName.StartsWith('D' + "")
                       select Person).Count();
        var result2 = Convert.ToString(result1);
        foreach(var person in result2)
        {
            Console.WriteLine(person);
        }

        // 3.	Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name

        var result3 = from Person in people
                      where Person.Age > 40
                      orderby Person.FirstName descending
                      select Person;
        foreach (var person in result3)
        {
            Console.Write(person.FirstName + ' ');
            Console.WriteLine(person.Age);
        }

       // 4.	write linq statement for people’s full name(concat firstname and last name)

        var result4 = from Person in people                     
                      select Person;
        foreach( var person in result4)
        {
            //Console.WriteLine(person.LastName);
            //Console.WriteLine(person.FirstName); 
            Console.WriteLine(person.FirstName +' '+ person.LastName);
        }


    }

    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }         
}

