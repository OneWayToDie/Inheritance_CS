using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	public abstract class Triangle : Shape, IHaveHeight
	{
		public Triangle(int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) { }
		public abstract double GetHeight();
	}
}
