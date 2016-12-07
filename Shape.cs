using System;
namespace Chris_Harrison_Shape_SpreadEx
{
	public abstract class Shape
	{
		public abstract string shapeSize { get; }

		public override string ToString()
		{
			return shapeSize;
		}
	}
}
