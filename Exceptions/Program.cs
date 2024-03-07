using System;

namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(15);
            numList.Add(-5);
            numList.Add(0);

            foreach (int i in numList)
            {
                try
                {
                    Circle newCircle = new Circle(i);
                    newCircle.SetRadius();
                }
                catch (InvalidRadiusException)
                {
                    // Constructor will print message.
                }
                finally { Console.WriteLine($"End of execution for: {i}\n"); }
            }
        }
    }
}