using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public class Circle : Shape
	{
		private int x;
		private int y;
		private int size;

		public Circle(int x, int y, int size)
		{
			this.x = x;
			this.y = y;
			this.size = size;
		}

		public override string shapeSize
		{
			get
			{
				return "Circle (" + x + "," + y + ") size=" + size;
			}
		}
	}
}
