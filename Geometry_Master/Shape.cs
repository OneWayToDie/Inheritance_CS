using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Master
{
	enum Color
	{
		Red = 0x000000FF,
		Green = 0x0000FF00,
		Blue = 0x00FF0000,
		Yellow = 0x0000FFFF,
		Orange = 0x0000A5FF,
		White = 0x00FFFFFF
	};
	public abstract class Shape
	{
		protected int start_x;
		protected int start_y;
		protected int line_width;

		public const int MIN_START_X = 100;
		public const int MIN_START_Y = 100;
		public const int MAX_START_X = 1000;
		public const int MAX_START_Y = 600;
		public const int MIN_LINE_WIDTH = 1;
		public const int MAX_LINE_WIDTH = 32;
		public const int MIN_SIZE = 32;
		public const int MAX_SIZE = 512;
		public Shape(int start_x, int start_y, int line_width)
		{
			Set_StartX(start_x);
			Set_StartY(start_y);
			Set_Line_Width(line_width);
		}
		public void Set_StartX(int start_x)
		{
			this.start_x = start_x < MIN_START_X ? MIN_START_X :
						  start_x > MAX_START_X ? MAX_START_X :
						  start_x;
		}

		public void Set_StartY(int start_y)
		{
			this.start_y = start_y < MIN_START_Y ? MIN_START_Y :
						  start_y > MAX_START_Y ? MAX_START_Y :
						  start_y;
		}

		public void Set_Line_Width(int line_width)
		{
			this.line_width = line_width < MIN_LINE_WIDTH ? MIN_LINE_WIDTH :
							 line_width > MAX_LINE_WIDTH ? MAX_LINE_WIDTH :
							 line_width;
		}

		protected int Filter_Size(int size)
		{
			return size < MIN_SIZE ? MIN_SIZE :
				   size > MAX_SIZE ? MAX_SIZE :
				   size;
		}
		public int Get_StartX()
		{
			return start_x;
		}
		public int Get_StartY()
		{
			return start_y;
		}
		public int Get_Line_Width()
		{
			return line_width;
		}
		public abstract double Area();
		public abstract double Perimeter();

		public virtual void Info()
		{
			Console.WriteLine($"Площадь фигуры: {Area()}");
			Console.WriteLine($"Периметр фигуры: {Perimeter()}");
		}
	}
}
