using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_20190213
{
    class Program
    {
        static void Main(string[] args)
        {
            exmpl10();
        }

        static void exmpl01()
        {
            //4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
            //каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. 
            Console.WriteLine("введите число А:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число B:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x<y)
            {
                for(int i=x; i<=y;i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write("{0} ", i);
                    Console.WriteLine();
                }
            }
        }

        static void exmpl02()
        {
            //5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
            //Например, если было введено число 345, то программа должна вывести число 543.
            Console.WriteLine("введите число А:");
            int x = Convert.ToInt32(Console.ReadLine());
            string str = x.ToString();
            char[] tmp = str.ToCharArray();
            Array.Reverse(tmp);
            string s = new string(tmp);
            int y = Int32.Parse(s);            
            Console.WriteLine(y);
        }

        static void exmpl03()
        {
            //11.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //a.А или В;
            //b.А и В;
            //c.В или С.
            bool a = true, b = false, c = false;
            Console.WriteLine("А или В = {0}", a || b);
            Console.WriteLine("А и В = {0}", a & b);
            Console.WriteLine("В или С = {0}", b || c);
        }

        static void exmpl04()
        {
            //12.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            Console.WriteLine("введите радиус круга:");
            double r = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
            Console.WriteLine("введите сторону квадрата:");
            double a = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);

            if ((r * r * 3.14) > (a * a))
                Console.WriteLine("площадь круга больше, чем площадь квадрата");
            else if ((r * r * 3.14) < (a * a))
                Console.WriteLine("площадь круга больше, чем площадь квадрата");
            else
                Console.WriteLine("квадрат и круг по площади равны");
        }

        static void exmpl05()
        {
            //20.	Считая, что Земля — идеальная сфера с радиусом R 6350 км, определить расстояние до линии горизонта от точки с заданной высотой над Землей.
            double r = 63500;
            Console.WriteLine("введите значеине высоты:");
            double a = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
            double b = Math.Round(Math.Sqrt((r + a) * (r + a) - r * r),2);
            Console.WriteLine("расстояние до линии горизонта от точки с заданной высотой над Землей: {0} км", b);
        }

        static void exmpl06()
        {
            //29.	Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: 
            //a. X и не(Z или Y) или не Z;
            //b. не X или X и(Y или Z);
            //c. (X или Y и не Z) и Z.
            bool x = false, y = true, z = false;
            Console.WriteLine("X и не(Z или Y) или не Z = {0}", (x & !(z || y) || !z));
            Console.WriteLine("не X или X и(Y или Z) = {0}", (!x || x & (y || z)));
            Console.WriteLine("(X или Y и не Z) и Z = {0}", ((x || y & !z) & z));
        }

        static void exmpl07()
        {
            //31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?
            Console.WriteLine("введите расстояние в километрах:");
            double km = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
            Console.WriteLine("введите расстояние в футах:");
            double ft = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
            if (km > (ft * 0.305))
                Console.WriteLine("расстояние в километрах больше, чем в футах: {0} км > {1} км", km, Math.Round(ft * 0.305, 2));
            else if (km < (ft*0.305))
                Console.WriteLine("расстояние в футах больше, чем в километрах: {0} км > {1} км", Math.Round(ft * 0.305, 2), km);
            else
                Console.WriteLine("расстояние в километрах и футах равны");
        }

        static void exmpl08()
        {
            //41.	Напечатать таблицу соответствия между весом в фунтах и весом в килограммах для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г).
            for(int i=1; i<=10; i++)
            {
                if (i==1)
                    Console.WriteLine("{0} фунт = {1} кг", i, Convert.ToDouble(i * 0.453));
                else if (i>=2 & i<=4)
                    Console.WriteLine("{0} фунта = {1} кг", i, Convert.ToDouble(i * 0.453));
                else
                    Console.WriteLine("{0} фунтов = {1} кг", i, Convert.ToDouble(i * 0.453));
            }
        }

        static void exmpl09()
        {
            //42.	Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81
            int[,] tab = new int[9, 9];
            for(int i=1; i<=9; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }

        static void exmpl10()
        {
            //43.	Дано натуральное число. 
            //a.Верно ли, что сумма его цифр больше 10 ?
            //b.Верно ли, что произведение его цифр меньше 50 ?
            //c.Верно ли, что количество его цифр есть четное число?
            //d.Верно ли, что это число четырехзначное? Составное условие и вложенный условный оператор не использовать.
            //e.Верно ли, что его первая цифра не превышает 6 ?
            //f.Верно ли, что оно начинается и заканчивается одной и той же цифрой? 
            //g.Определить, какая из его цифр больше: первая или последняя.
            Console.WriteLine("введите натуральное число:");
            string num = Console.ReadLine();            
            int sum = 0, prod=1;
            for(int i=0; i<num.Length; i++)
            {                
                int x = Int32.Parse(num[i].ToString());
                sum += x;
                prod *= x;
            }            

            if (sum > 10)
                Console.WriteLine("Верно ли, что сумма его цифр больше 10 ? ответ - да");
            else
                Console.WriteLine("Верно ли, что сумма его цифр больше 10 ? ответ - нет");

            if (prod<50)
                Console.WriteLine("Верно ли, что произведение его цифр меньше 50 ? ответ - да");
            else
                Console.WriteLine("Верно ли, что произведение его цифр меньше 50 ? ответ - нет");

            if (num.Length%2==0)
                Console.WriteLine("Верно ли, что количество его цифр есть четное число? ответ - да");
            else
                Console.WriteLine("Верно ли, что количество его цифр есть четное число? ответ - нет");

            if (num.Length==4)
                Console.WriteLine("Верно ли, что это число четырехзначное? ответ - да");
            else
                Console.WriteLine("Верно ли, что это число четырехзначное? ответ - нет");

            if (Int32.Parse(num[0].ToString())<=6)
                Console.WriteLine("Верно ли, что его первая цифра не превышает 6 ? ответ - да");
            else 
                Console.WriteLine("Верно ли, что его первая цифра не превышает 6 ? ответ - нет");

            if (num[0]==num[num.Length-1])
                Console.WriteLine("Верно ли, что оно начинается и заканчивается одной и той же цифрой? ответ - да");
            else
                Console.WriteLine("Верно ли, что оно начинается и заканчивается одной и той же цифрой? ответ - нет");

            if (num[0]>num[num.Length-1])
                Console.WriteLine("Определить, какая из его цифр больше: первая или последняя? ответ - первая");
            else if (num[0] < num[num.Length-1])
                Console.WriteLine("Определить, какая из его цифр больше: первая или последняя? ответ - последняя");
            else
                Console.WriteLine("Определить, какая из его цифр больше: первая или последняя? ответ - они равны");
        }
    }
}
