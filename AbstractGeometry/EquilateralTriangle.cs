using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	public class EquilateralTriangle : Triangle
	{
		private double side;
		public double Get_Side() => side;
		public void Set_Side(double side) => this.side = FilterSize((int)side);
		public EquilateralTriangle(double side, int start_x, int start_y, int line_width, Color color) : base(start_x, start_y, line_width, color) => Set_Side(side);

		public override double GetHeight() 
			=> Math.Sqrt(Math.Pow(side, 2) - Math.Pow(side / 2, 2));

		public override double GetArea() => side * GetHeight() / 2;
		public override double GetPerimeter() => 3 * side;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			PointF[] points =
		   {
				new PointF(StartX, StartY + (float)GetHeight()),
				new PointF(StartX + (float)side, StartY + (float)GetHeight()),
				new PointF(StartX + (float)(side / 2), StartY)
			};
			e.Graphics.DrawPolygon(pen, points);
			e.Graphics.FillPolygon(brush, points);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Равносторонний треугольник:");
			Console.WriteLine($"Сторона: {side}");
			Console.WriteLine($"Высота: {GetHeight():F2}");
			base.Info(e);
		}
	}
}
