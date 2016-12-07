using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public class Ellipse : Shape
	{
		private int x;
		private int y;
		private int diameterH;
		private int diameterV;

		public Ellipse(int x, int y, int diameterH, int diameterV)
		{
			this.x = x;
			this.y = y;
			this.diameterH = diameterH;
			this.diameterV = diameterV;
		}

		public override string shapeSize
		{
			get
			{
				return "Ellipse (" + x + "," + y + ") diameterH = " + diameterH + " diameterV = " + diameterV;
			}
		}
	}
}
