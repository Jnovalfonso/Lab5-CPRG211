using System;
namespace ExceptionExample
{
	public class Circle
	{
		int radius;

        public Circle()
		{
			this.radius = 1;
		}

		public Circle(int radius)
		{
			this.radius = radius;
		}

		public int GetRadius()
		{
			return this.radius;
		}

		public void SetRadius ()
		{
			Console.WriteLine($"Setting Circle radius of: {radius}");
			if (radius <= 0)
			{
				throw new InvalidRadiusException(radius.ToString());
			}

			else
			{
				Console.WriteLine("Valid Radius!");
			}
		}
		
	}

}


