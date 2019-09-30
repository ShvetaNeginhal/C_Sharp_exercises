using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo to show INTERFACE
namespace MultipleInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			//Rectangle r = new Rectangle();
			IShape3D shape = new Shape();
			shape.Draw();
			//shape.Erase();
			//r.FillingColour("bLACK");

		}
	}

	interface IShape2D
	{
		//Creating pure virtual function 
		void Draw();
		void Erase();
		void FillingColour(string colour);
	}


	interface IShape3D
	{
		void Draw();
		
	}

	abstract class Shape
	{
		abstract public void Draw();
		
	}
	//Rectangle IS A shape - (Abstraction) 

	class Rectangle : IShape3D, IShape2D
	{
		void IShape2D.Draw()
		{
			Console.WriteLine("Drawing 2D");
		}
		void IShape3D.Draw()
		{
			Console.WriteLine("Drawing 3D");
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
