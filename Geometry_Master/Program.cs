using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Master
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string delimiter = "\n----------------------------------------------\n";
			Console.WriteLine("Информация о фигурах:\n");

			var rectangle = new Rectangle(150, 100, 550, 100, 2);
			rectangle.Info();
			Console.WriteLine($"\n{delimiter}\n");

			var circle = new Circle(50, 800, 200, 1);
			circle.Info();
			Console.WriteLine($"\n{delimiter}\n");

			var triangle = new EquilateralTriangle(100, 550, 350, 2);
			triangle.Info();
			Console.WriteLine($"\n{delimiter}\n");
		}
	}
}
