// Напишите программу которая будет рассчитывать площадь круга;
double r,perimeter, area;
Console.WriteLine("Введите радиус вашего круга  ");
r = Convert.ToDouble(Console.ReadLine());
perimeter = 2*3.14*r;
area = 3.14 * Math.Pow(r,2);
Console.WriteLine("Периметр вашего круга {0}" ,perimeter);
Console.WriteLine("Площадь вашего круга: {0}",area);
Console.ReadKey();