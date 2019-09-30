using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo to show INTERFACE
namespace Shapes
{
	class Program	
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			r.Draw();
			r.Erase();
			r.FillingColour("bLACK");

		}
	}
	
	interface IShape
	{
		//Creating pure virtual function 
		void Draw();
		void Erase();
		void FillingColour(string colour);
	}


	class Shape3D
	{

	}

	//Rectangle IS A shape - (Abstraction) 

	class Rectangle : Shape3D,IShape
	{
		public void Draw()
		{
			Console.WriteLine("Drawing Rectangle");
		}

		public void Erase()
		{
			Console.WriteLine("Erasing the shape");
		}
		public void FillingColour(string colour)
		{
			Console.WriteLine($"Filling {colour} to the shape");
		}

	}

}
