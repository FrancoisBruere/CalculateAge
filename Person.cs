using System;

namespace CalculateAge
{
    public class Person
    {

        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timespan = DateTime.Now - Birthdate;
                var years = timespan.Days / 365;

                return years;
            }
          
        }
    }
}
