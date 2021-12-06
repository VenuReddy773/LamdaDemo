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
        }
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("111111", "venu", "hyd1", 15));
            listPersonsInCity.Add(new Person("222222", "Gopal", "hyd2", 65));
            listPersonsInCity.Add(new Person("333333", "Reddy", "hyd3", 35));
            listPersonsInCity.Add(new Person("444444", "Attla", "hyd4", 17));            
        }
    }
}

