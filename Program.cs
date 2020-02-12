using System;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lightbulbs in christmas tree set:");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            SimpleChristmasTreeSet simpleChristmasTreeSet = new SimpleChristmasTreeSet(inputValue);
            simpleChristmasTreeSet.PrintChristmatTreeSetState();
            ColorChristmasTreeSet colorChristmasTreeSet = new ColorChristmasTreeSet(inputValue);
            colorChristmasTreeSet.PrintChristmatTreeSetState();



        }
    }
}
