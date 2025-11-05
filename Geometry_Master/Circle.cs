using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	public class Circle : Shape
	{
		private double radius;
		public double Get_Radius()
		{
			return radius;
		}
		public void Set_Radius(double radius)
		{
			this.radius = Filter_Size((int)radius);
		}
		public Circle(double radius, int start_x, int start_y, int line_width): base(start_x, start_y, line_width)
		{
			Set_Radius(radius);
		}
		public double Diameter()
		{
			return 2 * radius;
		}
		public override double Area()
		{
			return Math.PI * radius * radius;
		}
		public override double Perimeter()
		{
			return Math.PI* Diameter();
		}
		public override void Info()
		{
			Console.WriteLine($"Круг:");
			Console.WriteLine($"Радиус: {radius}");
			Console.WriteLine($"Диаметр: {Diameter()}");
			base.Info();
		}
	}
}
