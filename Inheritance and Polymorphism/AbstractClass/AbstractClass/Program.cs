using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo to show ABSTRACT CLASS
namespace Shapes
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Rectangle r = new Rectangle();
			r.Draw();
			r.Erase();
			r.FillingColour("Black");

		}
	}

	abstract class Shape
	{
		//Creating pure virtual function
		abstract public void Draw();

		//Concrete method -- derived classes cannot override
		public void Erase()
		{
			Console.WriteLine("Erasing the shape");
		}

		//virtual class -- derived classes override
		public virtual void FillingColour(string colour)
		{
			Console.WriteLine($"Filling {colour} to the shape");
		}

	}
	//Rectangle IS A shape - Generalisation(Abstraction + Implementation) 
	class Rectangle : Shape
	{
		// Method Hiding - non Polymorphic : using new keyword instead of override

		override public void Draw()
		{
			Console.WriteLine("Drawing Rectangle");
		}


	}



}
