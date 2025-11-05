using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	public abstract class Triangle : Shape
	{
		public Triangle(int start_x, int start_y, int line_width) : base(start_x, start_y, line_width) { }
		public abstract double Get_Height();
	}
}
