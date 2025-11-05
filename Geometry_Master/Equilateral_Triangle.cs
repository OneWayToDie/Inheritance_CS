using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	public class EquilateralTriangle : Triangle
	{
		private double side;
		public double Get_Side()
		{
			return side;
		}
		public void Set_Side(double side)
		{
			this.side = Filter_Size((int)side);
		}
		public EquilateralTriangle(double side,  int start_x, int start_y,int line_width): base(start_x, start_y, line_width)
		{
			Set_Side(side);
		}
		public override double Get_Height()
		{
			return Math.Sqrt(Math.Pow(side, 2) - Math.Pow(side / 2, 2));
		}
		public override double Area()
		{ 
			return side* Get_Height() / 2;
		}
		public override double Perimeter()
		{
			return 3 * side;
		}
		public override void Info()
		{
			Console.WriteLine($"Равносторонний треугольник:");
			Console.WriteLine($"Сторона: {side}");
			Console.WriteLine($"Высота: {Get_Height():F2}");
			base.Info();
		}
	}
}
