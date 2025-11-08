using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	public class Square :Rectangle
	{
		double side;
		public double Get_Side() => this.side;
		public void Set_Side(double side) => this.side = FilterSize((int)side);

		public Square(double side, double width, double height, int startX, int startY, int lineWidth, Color color) : base(width, height, startX, startY, lineWidth, color) 
			=> Set_Side(side);
		public override double GetArea() => Math.Pow(side, 2);
		public override double GetPerimeter() => side * 4;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color);
			SolidBrush brush = new SolidBrush(Color);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (float)side, (float)side);
			e.Graphics.FillRectangle(brush, StartX, StartY, (float)side, (float)side);
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
		}
	}
}
