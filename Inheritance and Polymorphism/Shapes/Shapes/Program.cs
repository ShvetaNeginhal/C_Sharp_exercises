using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo to show INHERITANCE AND POLYMORPHISM
namespace Shapes
{
	class Program
	{
		static void Main(string[] args)
		{
			Shape s = new Shape();
			s.Draw();
			Rectangle r = new Rectangle();
			r.Draw();

			//OO Rule - Base Class ref variable can hold derived class object

			Shape shapeRef = new Rectangle();
			shapeRef.Draw();	//Late Binding
			
			//All methods in a class are default non-virtual
		}
	}

	class Shape
	{
		//To override a method in derived class
		virtual public void Draw()
		{
			Console.WriteLine("Drawing Shape");

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
