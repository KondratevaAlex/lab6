using System;

namespace lab6
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] ansper = new double[2];
			double[] anssur = new double[2];
			double difper, difsur;
			int choice;
			Student Student = new Student();
			Student.set();
			Student.printInfo();
			Student.getFIO();
			do
			{
				Console.WriteLine("\nВыберите вид фигур для сравнения:\n1 - Треугольники\n2 - Прямоугольники(квадраты)\n3 - Параллелограммы\n4 - Трапеции\n5 - Круги\n:::");
				choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						{
							Triangle [] arr = new Triangle[2];
							arr[0] = new Triangle();
							arr[1] = new Triangle();
							ObjectInfo [] obj = new ObjectInfo[2];
							obj[0] = new ObjectInfo();
							obj[1] = new ObjectInfo();
							for (int i = 0; i < 2; i++)
							{
								Console.WriteLine("\nВведите данные  треугольника:\n");
								arr[i].settri(arr[i]);
								obj[i].setInfo(obj[i]);
								arr[i].printtri(arr[i]);
								obj[i].printInfo(obj[i]);
								arr[i].triperimeter(out ansper[i]);
								arr[i].trisurf(ref anssur[i]);
							}
							difper = ansper[0] / ansper[1];
							difsur = anssur[0] / anssur[1];
							Console.Write("\n\nОтношение периметров треугольников друг к другу: ");
							Console.Write(difper);
							Console.Write("\nОтношение площадей треугольников друг к другу: ");
							Console.Write(difsur);
							break;
						}
					case 2:
						{
							Rectangle [] arr = new Rectangle[2];
							arr[0] = new Rectangle();
							arr[1] = new Rectangle();
							ObjectInfo [] obj = new ObjectInfo[2];
							obj[0] = new ObjectInfo();
							obj[1] = new ObjectInfo();
							for (int i = 0; i < 2; i++)
							{
								Console.WriteLine("\nВведите данные прямоугольника:\n");
								arr[i].setrect(arr[i]);
								obj[i].setInfo(obj[i]);
								arr[i].printrect(arr[i]);
								obj[i].printInfo(obj[i]);
								arr[i].rectperimeter(out ansper[i]);
								arr[i].rectsurf(ref anssur[i]);
							}
							difper = ansper[0] / ansper[1];
							difsur = anssur[0] / anssur[1];
							Console.Write("\n\nОтношение периметров прямоугольников друг к другу: ");
							Console.Write(difper);
							Console.Write("\nОтношение площадей прямоугольников друг к другу: ");
							Console.Write(difsur);
							break;
						}
					case 3:
						{
							Parallelogram [] arr = new Parallelogram[2];
							arr[0] = new Parallelogram();
							arr[1] = new Parallelogram();
							ObjectInfo [] obj = new ObjectInfo[2];
							obj[0] = new ObjectInfo();
							obj[1] = new ObjectInfo();
							for (int i = 0; i < 2; i++)
							{
								Console.WriteLine("\nВведите данные %d параллелограмма:\n");
								arr[i].setpar(arr[i]);
								obj[i].setInfo(obj[i]);
								arr[i].printpar(arr[i]);
								obj[i].printInfo(obj[i]);
								arr[i].parperimeter(out ansper[i]);
								arr[i].parsurf(ref anssur[i]);
							}
							difper = ansper[0] / ansper[1];
							difsur = anssur[0] / anssur[1];
							Console.Write("\n\nОтношение периметров параллелограммов друг к другу: ");
							Console.Write(difper);
							Console.Write("\nОтношение площадей параллелограммов друг к другу: ");
							Console.Write(difsur);
							break;
						}
					case 4:
						{
							Trapezoid [] arr = new Trapezoid[2];
							arr[0] = new Trapezoid();
							arr[1] = new Trapezoid();
							ObjectInfo [] obj = new ObjectInfo[2];
							obj[0] = new ObjectInfo();
							obj[1] = new ObjectInfo();
							for (int i = 0; i < 2; i++)
							{
								Console.WriteLine("\nВведите данные трапеции:\n");
								arr[i].settrap(arr[i]);
								obj[i].setInfo(obj[i]);
								arr[i].printtrap(arr[i]);
								obj[i].printInfo(obj[i]);
								arr[i].trapperimeter(out ansper[i]);
								arr[i].trapsurf(ref anssur[i]);
							}
							difper = ansper[0] / ansper[1];
							difsur = anssur[0] / anssur[1];
							Console.Write("\n\nОтношение периметров трапеций друг к другу: ");
							Console.Write(difper);
							Console.Write("\nОтношение площадей трапеций друг к другу: ");
							Console.Write(difsur);
							break;
						}
					case 5:
						{
							Circle [] arr = new Circle[2];
							arr[0] = new Circle();

							arr[1] = new Circle();
							ObjectInfo [] obj = new ObjectInfo[2];
							obj[0] = new ObjectInfo();
							obj[1] = new ObjectInfo();
							for (int i = 0; i < 2; i++)
							{
								Console.WriteLine("\nВведите данные %d круга:\n");
								arr[i].setcirc(arr[i]);
								obj[i].setInfo(obj[i]);
								arr[i].printcirc(arr[i]);
								obj[i].printInfo(obj[i]);
								arr[i].circperimeter(out ansper[i]);
								arr[i].circsurf(ref anssur[i]);
							}
							difper = ansper[0] / ansper[1];
							difsur = anssur[0] / anssur[1];
							Console.Write("\n\nОтношение периметров кругов друг к другу: ");
							Console.Write(difper);
							Console.Write("\nОтношение площадей кругов друг к другу: ");
							Console.Write(difsur);
							break;
						}
				}
			} while (choice != 0);
		}
	}
}

