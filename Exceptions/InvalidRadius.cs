using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    [Serializable]
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        {
            string message = "The radius of the circle can't be less or equal to zero.";
            Console.WriteLine(message);
        }
        public InvalidRadiusException(string message) : base(message)
        {
            message = $"Invalid Radius, '{message}' must be greater than zero.";
            Console.WriteLine(message);
        }
    }
}
