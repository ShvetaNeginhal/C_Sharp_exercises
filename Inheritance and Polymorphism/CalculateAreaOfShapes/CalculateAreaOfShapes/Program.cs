using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaOfShapes
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle c = new Circle();
			double ca = c.CalArea();
			Console.WriteLine("Area of Circle = " + ca );
			Rectangle r = new Rectangle();
			double ra = r.CalArea();
			Console.WriteLine("Area of Rectangle = " + ra);
			Triangle t = new Triangle();
			double ta = t.CalArea();
			Console.WriteLine("Area of Triangle = " + ta);


		}
	}

	interface IShape
	{
		double CalArea();
	}

	class Circle : IShape
	{
		public double CalArea()
		{
			Console.WriteLine("Enter radius");
			int r = int.Parse(Console.ReadLine());
			double area = 3.14 * r * r;
			return area;

		}
	}
	class Rectangle : IShape
	{
		public double CalArea()
		{
			Console.WriteLine("Enter length and breath");
			int l = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			return l * b;
		}
	}
	class Triangle : IShape
	{
		public double CalArea()
		{
			Console.WriteLine("Enter base and height");
			int l = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			return 0.5 *(l * b);
		}
	}

}
