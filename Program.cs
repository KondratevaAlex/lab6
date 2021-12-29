using System;

namespace lab6
{
	class Program
	{
		static void Main(string[] args)
		{
			double ansper, anssur, dif;
			int choice;
			do
			{
				Console.WriteLine("\nВыберите вид фигур для сравнения:\n1 - Треугольники\n2 - Прямоугольники(квадраты)\n3 - Параллелограммы\n4 - Трапеции\n5 - Круги\n:::");
				choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						{
							Triangle arr = new Triangle();
							ObjectInfo obj = new ObjectInfo();

							Console.WriteLine("\nВведите данные  треугольника:\n");
							arr.settri(arr);
							obj.setInfo(obj);
							arr.printtri(arr);
							obj.printInfo(obj);
							ansper = arr.triperimeter(arr);
							anssur = arr.trisurf(arr);

							dif = anssur / ansper;
							Console.Write("\n\nОтношение объема треугольника к его периметру: ");
							Console.Write(dif);
							break;
						}
					case 2:
						{
							Rectangle arr = new Rectangle();
							ObjectInfo obj = new ObjectInfo();
							Console.WriteLine("\nВведите данные прямоугольника:\n");
							arr.setrect(arr);
							obj.setInfo(obj);
							arr.printrect(arr);
							obj.printInfo(obj);
							ansper = arr.rectperimeter(arr);
							anssur = arr.rectsurf(arr);
							dif = anssur / ansper;
							Console.WriteLine("\n\nОтношение объема прямоугольника к его периметру: ");
							Console.Write(dif);
							break;
						}
					case 3:
						{
							Parallelogram arr = new Parallelogram();
							ObjectInfo obj = new ObjectInfo();
							Console.WriteLine("\nВведите данные %d параллелограмма:\n");
							arr.setpar(arr);
							obj.setInfo(obj);
							arr.printpar(arr);
							obj.printInfo(obj);
							ansper = arr.parperimeter(arr);
							anssur = arr.parsurf(arr);
							dif = anssur / ansper;
							Console.WriteLine("\n\nОтношение объема параллелограмма к его периметру: ");
							Console.Write(dif);
							break;
						}
					case 4:
						{
							Trapezoid arr = new Trapezoid();
							ObjectInfo obj = new ObjectInfo();
							Console.WriteLine("\nВведите данные трапеции:\n");
							arr.settrap(arr);
							obj.setInfo(obj);
							arr.printtrap(arr);
							obj.printInfo(obj);
							ansper = arr.trapperimeter(arr);
							anssur = arr.trapsurf(arr);
							dif = anssur / ansper;
							Console.WriteLine("\n\nОтношение объема трапеции к его периметру: ");
							Console.Write(dif);
							break;
						}
					case 5:
						{
							Circle arr = new Circle();
							ObjectInfo obj = new ObjectInfo();
							Console.WriteLine("\nВведите данные %d круга:\n");
							arr.setcirc(arr);
							obj.setInfo(obj);
							arr.printcirc(arr);
							obj.printInfo(obj);
							ansper = arr.circperimeter(arr);
							anssur = arr.circsurf(arr);
							dif = anssur / ansper;
							Console.WriteLine("\n\nОтношение объема круга к его периметру: ");
							Console.Write(dif);
							break;
						}
				}
			} while (choice != 0);
		}
	}
}

