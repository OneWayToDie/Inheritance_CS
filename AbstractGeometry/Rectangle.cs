using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	public class Rectangle :Shape
	{
		double height;
		double width;
		public double Width
		{
			get => width;
			set => width = FilterSize(value);
		}
		public double Height
		{
			get => height;
			set => height = FilterSize(value);
		}
		public Rectangle(double width, double height, int startX, int startY, int lineWidth, Color color) : base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}
		public override double GetArea() => width * height;
		public override double GetPerimeter() => (width + height) * 2;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
			e.Graphics.FillRectangle(brush, StartX, StartY, (float)width, (float)Height);		
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType().ToString().Split('.').Last()+":");
			Console.WriteLine($"Ширина: {width}");
			Console.WriteLine($"Высота: {height}");
			base.Info(e);
		}
	}
}
