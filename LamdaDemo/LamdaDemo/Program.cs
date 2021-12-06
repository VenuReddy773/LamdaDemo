using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);
            Retrieve_TopTwo_OfAgeAbove60(listPersonsInCity);
            Retrieve_Teenagers(listPersonsInCity);
            Retrieve_AverageAge(listPersonsInCity);
        }
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("111111", "venu", "hyd1", 15));
            listPersonsInCity.Add(new Person("222222", "Gopal", "hyd2", 65));
            listPersonsInCity.Add(new Person("333333", "Reddy", "hyd3", 35));
            listPersonsInCity.Add(new Person("444444", "Attla", "hyd4", 17));            
        }
        private static void Retrieve_TopTwo_OfAgeAbove60(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            }
        }
        private static void Retrieve_Teenagers(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age > 13 && e.Age < 19)).ToList())
            {
                Console.WriteLine("Name: {0} Age: {1}", person.Name, person.Age);
            }
        }
        private static void Retrieve_AverageAge(List<Person> listPersonsInCity)
        {
            var avgAge = listPersonsInCity.Average(e => e.Age);  
            Console.WriteLine("Average Age is : {0}",avgAge);            
        }
    }
}

