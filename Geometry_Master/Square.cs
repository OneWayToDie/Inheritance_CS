using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	public class Square : Shape
	{
		private double side;
		public double Get_Side()
		{
			return this.side;
		}
		public void Set_Side(double side)
		{
			this.side = Filter_Size((int)side);
		}
		public Square(double side, int start_x, int start_y, int line_width) :base(start_x, start_y, line_width)
		{
			Set_Side(side);
		}
		public override double Area()
		{
			return Math.Pow(side, 2);
		}
		public override double Perimeter()
		{
			return side * 4;
		}
		public override void Info()
		{
			Console.WriteLine($"Квадрат:");
			Console.WriteLine($"Все стороны равны: {side}");
			base.Info();
		}
	}
}
