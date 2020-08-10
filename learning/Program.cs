using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    partial class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = ListManager.toSampleData();

            foreach(var person in people)
            {
                Console.WriteLine($"firstname: {person.firstName}, lastname: {person.lastName}, dob:{person.dob.ToShortDateString()}, yearsofexerience: {person.yearsOfExperience} ");
            }

            Console.WriteLine("**********************");

            //order the list
            //List<Person> sortedPeople =  people.OrderBy(x => x.yearsOfExperience).ThenByDescending(x => x.firstName).ToList();

            //find scenearios in the list that follow a condition
            //List<Person> sortedPeople = people.Where(person => person.yearsOfExperience > 5 && person.dob.Day == 3).ToList();



            /*foreach (var person in sortedPeople)
            {
                Console.WriteLine($"firstname: {person.firstName}, lastname: {person.lastName}, dob:{person.dob.ToShortDateString()}, yearsofexerience: {person.yearsOfExperience} ");
            } */

            var yearsTotal = 0;

            //yearsTotal = people.Sum(person => person.yearsOfExperience);

            yearsTotal = people.Where(person => person.dob.Month == 2).Sum(person => person.yearsOfExperience);

            Console.WriteLine(yearsTotal);



            Console.ReadKey();

        }
    }
}
