#define ABSTRACT_1
//#define ABSTRACT_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;   //DllImport
using System.Windows.Forms;    

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs( graphics, window_rect );
#if ABSTRACT_1
			Rectangle rectangle = new Rectangle(100, 40, 300, 30, 3, Color.AliceBlue);
			rectangle.Info(e);
			Circle circle = new Circle(50, 430, 30, 3, Color.Red);
			circle.Info(e);
			Square square = new Square(100, 100, 100, 560, 30, 3, Color.Yellow);
			square.Info(e);
			EquilateralTriangle triangle = new EquilateralTriangle(100, 760, 70, 3, Color.Yellow);
			triangle.Info(e);
			IsoscalesTriangle iso = new IsoscalesTriangle(75, 150, 500, 200, 3, Color.Green);
			iso.Info(e);

#endif
#if ABSTRACT_2
			Shape[] shapes =
				{
				new Rectangle(100, 40, 300, 30, 3, Color.AliceBlue),
				new Circle(50, 430, 30, 3, Color.Red),
				new Square(100, 100, 100, 560, 30, 3, Color.Yellow),
				new EquilateralTriangle(100, 760, 70, 3, Color.Yellow),
				new IsoscalesTriangle(75, 150, 500, 200, 3, Color.Green)
			};
			for (int i = 0; i < shapes.Length; i++)
			{
				if ((shapes[i] is IHaveDiagonal))
					shapes[i].Draw(e);
			} 
#endif
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
