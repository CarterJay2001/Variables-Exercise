using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jaylon";
            int myAge = 20;
            char myInitial = 'J';
            bool loveLife = true;
            double myHairs = 115.3;
            decimal myWeight = 155.7m;

            Console.WriteLine($"My name is {myName}, I am {myAge} years old and " +
                $"weigh {myWeight} pounds! Sometimes I go by {myInitial} and if " +
                $"you're wondering if I love life it's {loveLife}. Fun fact, I " +
                $"have {myHairs} thousand hairs on my head!");
        }
    }
}
