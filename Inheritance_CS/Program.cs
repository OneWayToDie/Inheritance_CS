//#define INHERITANCE_OLD
//#define INHERITANCE_NEW
#define SAVE
//#define READ
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static readonly string delimiter = "\n--------------------------------------------------------------------------------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_OLD
			Console.WriteLine("===========================Academy================================\n");
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter); 
#endif
#if INHERITANCE_NEW
			Human human = new Human("Pinkman", "Jessie", 22);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student(human, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher(new Human("White", "Walter", 50), "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human h_hank = new Human("Schreder", "Hank", 40);
			Student s_hank = new Student(h_hank, "Criminalictic", "OBN", 50, 60);
			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberd");
			graduate.Info();
#endif
#if SAVE
			Console.WriteLine("\t\t\t===========================================Academy===========================================\n\n");
			//Base-class pointers: Generalization(Upcast - приведение дочернего объекта к базовому типу)
			Human[] group =
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 60, "How to catch Heisenberg"),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 98, 99),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
				new Teacher("Schwazenegger", "Arnold", 78, "Heavy Metal", 65)
			};
			Console.WriteLine(delimiter);
			//Specialization:
			for (int i = 0; i < group.Length; i++)
			{
				//group[i].Info();
				Console.WriteLine(group[i].ToString());
				Console.WriteLine(delimiter);
			}
			//https://learn.microsoft.com/ru-ru/dotnet/api/system.io.streamwriter?view=net-8.0
			using (StreamWriter writer = new StreamWriter("Academy.txt"))	//StreamWriter - нужен для записи символов в поток записи в файл
			{
				writer.WriteLine("\t\t\t===========================================Academy===========================================\n\n");
				foreach (var Human in group)
				{
					writer.WriteLine($"{Human} {delimiter}");
				}
			}
			Process.Start	//Запускаю процесс открытия файла в системе, в который записали нашу группу
				(
				new ProcessStartInfo //Создаем новый объект, который содержит настройки для запуска процесса
				{
						FileName = "Academy.txt",	//Указал имя файла
						UseShellExecute = true      //Включает использование оболочки Windows для запуска, и позволяет автоматически определить через какую программу откроется файл
													//https://learn.microsoft.com/ru-ru/dotnet/api/system.diagnostics.processstartinfo.useshellexecute?view=net-8.0
				}
				);
#endif
#if READ
			string filename = "Academy.txt";	//Создал переменную в которую записал название файла, который должен буду считать

			string[] lines = File.ReadAllLines(filename);	//File.ReadAllLines - Открывает текстовый файл, считывает все строки файла в массив строк и затем закрывает файл.
															//https://learn.microsoft.com/ru-ru/dotnet/api/system.io.file.readalllines?view=net-8.0	
			foreach (var line in lines)
			{
				Console.WriteLine(line);	
			}
#endif
		}
	}
}
