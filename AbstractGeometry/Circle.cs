using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	public class Circle : Shape, IHaveDiameter
	{
		double radius;
		public double Get_Radius() => radius;
		public void Set_Radius(double radius) => this.radius = FilterSize((int)radius);
		public Circle(double radius, int startX, int startY, int line_width, Color color) : base(startX, startY, line_width, color) => Set_Radius(radius);
		public double GetDiameter()
		{
			return Get_Radius() * 2;
		}
		public override double GetArea() => Math.PI * radius * radius;
		public override double GetPerimeter() => Math.PI * GetDiameter();
		
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			float diameter = (float)(radius * 2);
			e.Graphics.DrawEllipse(pen, StartX, StartY, diameter, diameter);
			e.Graphics.FillEllipse(brush, StartX, StartY, diameter, diameter);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last() + ":");
			Console.WriteLine($"Радиус: {radius}");
			Console.WriteLine($"Диаметр: {GetDiameter()}");
			base.Info(e);
		}
	}
}