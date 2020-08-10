using System;
using System.Collections.Generic;

namespace learning
{
    partial class Program
    {
        public class ListManager
        {
            public static List<Person> toSampleData()
            {
                List<Person> output = new List<Person>();

                output.Add(new Person { firstName = "Tim", lastName = "jumba", dob = Convert.ToDateTime("3/02/2017"), yearsOfExperience = 3 });
                output.Add(new Person { firstName = "Timi", lastName = "dakolo", dob = Convert.ToDateTime("4/08/2007"), yearsOfExperience = 1 });
                output.Add(new Person { firstName = "damoko", lastName = "hundeyin", dob = Convert.ToDateTime("3/02/2020"), yearsOfExperience = 6 });
                output.Add(new Person { firstName = "ringingo", lastName = "sumbata", dob = Convert.ToDateTime("3/02/2001"), yearsOfExperience = 81 });

                return output;
            }
        }
    }
}
