using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	public class Rectangle : Shape
	{
		private double width;
		private double height;
		public double Get_Width()
		{ 
			return this.width;
		}
		public double Get_Height()
		{
			return this.height;
		}
		public void Set_Width(double width)
		{
			this.width = Filter_Size((int)width);
		}
		public void Set_Height(double height)
		{
			this.height = Filter_Size((int)height);
		}
		public Rectangle(double width, double height, int start_x, int start_y, int line_width): base(start_x, start_y, line_width)
		{
			Set_Width(width);
			Set_Height(height);
		}
		public override double Area()
		{
			return width * height;
		}
		public override double Perimeter()
		{
			return (width + height) * 2;
		}
		public override void Info()
		{
			Console.WriteLine($"Прямоугольник:");
			Console.WriteLine($"Стороны: {width} * {height}");
			base.Info();
		}
	}
}
