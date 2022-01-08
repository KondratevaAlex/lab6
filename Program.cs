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
			Student Student1 = new Student();//вызов конструктора без параметров
			Student1.printInfo();

			Student Student2 = new Student("Ivanov");//вызов конструктора с одним параметром
			Student2.printInfo();

			Student student3 = new Student("Ivan", "Ivanovich", "Popov", 21);//вызов конструктора со всеми параметрами
			student3.printInfo();

			int counter = Student.getCount();
			Console.WriteLine("Количество студентов: " + counter);

			Triangle[] arrtri = new Triangle[3];
			arrtri[0] = new Triangle(1);
			arrtri[1] = new Triangle(2);
			arrtri[2] = new Triangle(3);

			for (int i = 0; i < 3; i++)
				arrtri[i].printtri(arrtri[i]);

			Teacher teacher = new Teacher();
			teacher.set();
			teacher.printInfo();
			teacher.estimate();

			Rectangle[] Array = new Rectangle[3];
			Console.WriteLine("\nВведите координаты 5 точек: ");
			for (int i = 0; i < 3; i++)
			{
				Array[i] = new Rectangle();
				Array[i].setrect(Array[i]);
			}
			Console.WriteLine("Одномерный массив точек: ");
			for (int i = 0; i < 3; i++)
			{
				Array[i].printrect(Array[i]);
			}

			Rectangle[,] newArray = new Rectangle[2, 2];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					newArray[i, j] = new Rectangle();
					newArray[i, j].setrect(newArray[i, j]);
				}
			}
			Console.WriteLine("Двумерный массив точек\n");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 2; j++)
					newArray[i, j].printrect(newArray[i, j]);
				Console.WriteLine("\n");
			}

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
							Rectangle Plus = arr[0] + arr[1];
							Console.Write("\nУнарный плюс: Plus = M + K : ");
							Plus.printrect(Plus);

							Plus = arr[0]++;
							Console.WriteLine("\nИнкремент: Plus = ++M : ");
							Plus.printrect(Plus);
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

