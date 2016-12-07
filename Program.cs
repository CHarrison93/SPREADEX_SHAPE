using System;

namespace Chris_Harrison_Shape_SpreadEx
{
	class MainClass
	{
		static void Main()
		{
			Shape[] shapes =
			{
				//Declare Shapes
				new Rectangle(10,10,30,40),
				new Square(15,30,35),
				new Ellipse(100,150,300,200),
				new Circle(1,1,300),
				new Textbox(5,5,200,100,"sample text")

			};

			//Print Shapes
			string tabs = "----------------------------------------------------------------";
			Console.WriteLine(tabs);
			Console.WriteLine("Requested Drawing");
			Console.WriteLine(tabs);
			foreach (Shape s in shapes)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine(tabs);
		}
	}
}