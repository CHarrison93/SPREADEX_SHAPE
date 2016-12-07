using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public class Textbox : Shape
	{
		private int x;
		private int y;
		private int width;
		private int height;
		private string text;

		public Textbox(int x, int y, int width, int height, string text)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			this.text = text;
		}

		public override string shapeSize
		{
			get
			{
				return "Textbox (" + x + "," + y + ") width=" + width + " height=" + height + " Text=\"" + text + "\"";
			}
		}
	}
}
