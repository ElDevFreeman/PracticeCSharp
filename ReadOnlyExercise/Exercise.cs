using System;
using System.Collections.Generic;
using System.Text;

namespace ReadOnlyExercise
{

    internal class Exercise
    {
         private readonly int age = 20;

        private string _password;

         //Write Only property
        public string Password { set { _password = value; } }

        public void PrintReadOnlyProperty()
        {
            Console.WriteLine("The age is: " + age);
        }

    }
}
