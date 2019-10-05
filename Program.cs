using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите действительное число: [x,xxx]");
            float x = float.Parse(Console.ReadLine());
            int d = (int)(x * 10) % 10;
            Console.WriteLine(d); 1-я задача*/

            /*Console.WriteLine("Введите кол-во секунд");
            int sec = int.Parse(Console.ReadLine());
            int hours = sec / 3600;
            int minutes = (sec - hours * 3600)/60;
            Console.WriteLine("Прошло "+hours+" часов "+minutes+" минут."); 2-я задача*/

            /*Console.WriteLine("Введите время в формате ЧЧ:ММ:СС");
            Console.Write("12>Часы: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("60>Минуты: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("60>Секунды: "); //в 1 секунде 0.008(3) градуса,поэтому я взял значение 0.0083
            int seconds = int.Parse(Console.ReadLine());
            int deg = hours * 3600 + minutes * 60 + seconds;
            double angle = deg * 0.0083;
            Console.WriteLine("В " + hours + ":" + minutes + ":" + seconds + " угол часовой стрелки относительно полуночи составлял " + angle + " градусов."); 3-я задача*/

            /*int a = 5;
            int b = 8;
            a += b;//13
            b -= a;//-5
            a += b;//8
            b *= -1;//5
            Console.WriteLine(a+" "+b); 4-я задача*/

            /*Console.Write("Введите 1-й катет: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-й катет: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a * a + b * b;
            int c = Convert.ToInt32(Math.Sqrt(sum));
            Console.WriteLine(c); 5-я задача*/


            /*int a, b, c, d;
            Console.Write("Введите 4х значное число: ");
            int num = int.Parse(Console.ReadLine());
            if (9999 >= num && num >= 1000)
            {
                a = num % 10;
                b = (num / 10) % 10;
                c = (num / 100) % 10;
                d = num / 1000;
                Console.WriteLine(a*b*c*d);
            } 6-я задача*/

            /*int a, b, c;
            Console.Write("Введите 3х значное число: ");
            int num = int.Parse(Console.ReadLine());
            if (999 >= num && num >= 100)
            {
                a = num / 100;
                b = (num / 10) % 10 * 10;
                c = num % 10 * 100;
                int reversed = a + b + c;
                Console.WriteLine(reversed);
            } 7-я задача*/

            /*Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int result = 7+x*(-1+x*(2+x*(-5+3*x)));
            Console.WriteLine(result); 8-я задача*/

            /*int a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
            float delta, deltaX, deltaY, deltaZ, mainX, mainY, mainZ;
            Console.WriteLine("Для системы уравнений \na1*x+b1*y+с1*z=d1\na2*x+b2*y+с2*z=d2\na3*x+b3*y+c3*z=d3\nВведите значения a(1,2,3);b(1,2,3);c(1,2,3);d(1,2,3)");
             a1 = int.Parse(Console.ReadLine());
             a2 = int.Parse(Console.ReadLine());
             a3 = int.Parse(Console.ReadLine());
              b1 = int.Parse(Console.ReadLine());
              b2 = int.Parse(Console.ReadLine());
              b3 = int.Parse(Console.ReadLine());
               c1 = int.Parse(Console.ReadLine());
               c2 = int.Parse(Console.ReadLine());
               c3 = int.Parse(Console.ReadLine());
                d1 = int.Parse(Console.ReadLine());
                d2 = int.Parse(Console.ReadLine());
                d3 = int.Parse(Console.ReadLine());

            Console.Write($"Система уравнений: \n{a1}x+{b1}y+{c1}z={d1}\n{a2}x+{b2}y+{c2}z={d2}\n{a3}x+{b3}y+{c3}z={d3}\n");
            delta = a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2 - a1 * b3 * c2 - a2 * b1 * c3 - a3 * b2 * c1;
            if (delta != 0)
            {
                deltaX = d1 * b2 * c3 + d2 * b3 * c1 + d3 * b1 * c2 - d1 * b3 * c2 - d2 * b1 * c3 - d3 * b2 * c1;
                deltaY = a1 * d2 * c3 + a2 * d3 * c1 + a3 * d1 * c2 - a1 * d3 * c2 - a2 * d1 * c3 - a3 * d2 * c1;
                deltaZ = a1 * b2 * d3 + a2 * b3 * d1 + a3 * b1 * d2 - a1 * b3 * d2 - a2 * b1 * d3 - a3 * b2 * d1;

                mainX = deltaX / delta;
                mainY = deltaY / delta;
                mainZ = deltaZ / delta;

                Console.Write($"Ответ системы уравнений:x={mainX};y={mainY};z={mainZ}\n");
            }
            else { Console.WriteLine("Определитель матрицы равен 0,решение невозможно"); } 9-я задача*/

            /*string[,] tab = { { "Вид транспорта", "Номер маршрута", "Протяж.маршрута(км)", "Время в дороге(мин)" }, { "5", "6", "7", "8" }, { "9", "10", "11", "12" }, { "13", "14", "15", "16" } };
            Console.WriteLine("Необходимые данные: Тр(трамвай);Тс(троллейбус);А(автобус)\n12;17;12a \n27,55;13,6;57,3;\n75;57;117");
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите вид транспорта: ");
                tab[i, 0] = Console.ReadLine();
            }
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите номер маршрута: ");
                tab[i, 1] = Console.ReadLine();
            }
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите протяж.маршрута: ");
                tab[i, 2] = Console.ReadLine();
            }
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите время в дороге: ");
                tab[i, 3] = Console.ReadLine();
            }
            Console.WriteLine("Данные обрабатываются...\n\n\n");
            Console.WriteLine("Общественный транспорт\n______________________________________________________________________");
            Console.WriteLine("|" + tab[0, 0] + "|" + tab[0, 1] + "|" + tab[0, 2] + "|" + tab[0, 3] + "|");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|" + tab[1, 0] + "|" + tab[1, 1] + "|" + tab[1, 2] + "|" + tab[1, 3] + "|");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|" + tab[2, 0] + "|" + tab[2, 1] + "|" + tab[2, 2] + "|" + tab[2, 3] + "|");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|" + tab[3, 0] + "|" + tab[3, 1] + "|" + tab[3, 2] + "|" + tab[3, 3] + "|");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|Перечисляемый тип: Тр-трамвай, Тс-тролейбус, А - автобус|"); 1-я индивидуальная задача*/




            /*Console.WriteLine("Для уравнений \ny = (sin^3)*((x^2)+a)^2 - √x/b\nz = x^2/a + cos(x+b)^3\nВведите значения a,b,x");
            int a, b, x;
            double result;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Знаменатель дроби равен 0,решение невозможно");
            }
            else
            {
                result = Math.Pow(Math.Sin(Math.Pow(x * x + a, 2)), 3) - Math.Sqrt(x / b);
                Console.WriteLine($"y = {result}");
            }

            if (a == 0)
            {
                Console.WriteLine("Знаменатель дроби равен 0,решение невозможно");
            }
            else
            {
                result = x * x / a + Math.Cos(Math.Pow(x + b, 3));
                Console.WriteLine($"z = {result}");
            }2-я индивидуальная задача*/

        }
    }       
}

