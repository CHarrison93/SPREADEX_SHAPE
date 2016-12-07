using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public class Square : Shape
	{
		private int x;
		private int y;
		private int size;

		public Square(int x, int y, int size)
		{
			this.x = x;
			this.y = y;
			this.size = size;
		}

		public override string shapeSize
		{
			get
			{
				return "Square (" + x + "," + y + ") size=" + size;
			}
		}
	}
}
