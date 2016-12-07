using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public class Rectangle : Shape
	{
		private int x;
		private int y;
		private int width;
		private int height;

		public Rectangle(int x, int y, int width, int height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		public override string shapeSize
		{
			get
			{
				return "Rectangle (" + x + "," + y + ") width=" + width + " height=" + height;
			}
		}
	}
}
