using System;

namespace CalculateAge
{

    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1976,11,19));

            //person.Birthdate = (new DateTime(1976, 11, 19));

            Console.WriteLine("I am {0} years old!",person.Age);

        }
    }
}
