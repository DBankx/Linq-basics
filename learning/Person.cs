using System;

namespace learning
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearsOfExperience { get; set; }
        public DateTime dob { get; set; }

        public string fullName { 
            get
            {
                return $"{firstName} {lastName}";
            } 
        }
    }
}
