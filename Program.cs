using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");

             int a = 0;//создаем переменную а (value-type)
             Console.WriteLine(a);//вывели на экран
             string a_str = a.ToString();//создали переменную строку ->"0"
             Console.WriteLine(a_str);//опять вывели на экран
             Console.WriteLine(a_str.Length);
             Console.WriteLine(int.MaxValue);//обращение к статическому полю*/
            /*double foo = 1;
            foo /= 3;
            Console.WriteLine("foo={0},{1}",foo,15);
            foo *= 3;
            Console.WriteLine("foo={0}", foo);*/

            /*char symb = 'Я'; //(char)48;
            Console.WriteLine(symb);
            Console.WriteLine(sizeof(char));*/

            /*string str1 = null;
            string strt2 = "";
            int? a = null;//nulable тип
            //int b = a.GetValueOrDefault();
            int b = a ?? 3;
            Console.WriteLine(b);*/
            /*double a, b;

            Console.Write("Введите а: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            //посчитали результат
            double x = -b / a;
            //вывести на экран
            Console.WriteLine("x={0};  a={1};  b={2}", x,a,b);
            Console.WriteLine("До свидания");*/
            //-------------2 занятие------------------------------//
            //Задача. Определить, принадлежит ли число промежутку
            //ввод: a,b - 2 числа, x-проверяемое значение
            //вывод: сказать, где лежит

            /*//-------------конструкция if, else if----------------//
            //ввод исходных данных
            double a, b, x;
            Console.Write("Введите число а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число x: ");
            x = Convert.ToDouble(Console.ReadLine());
            
            if (a > b)
            {
                double temp = a;
                a = b;
                b=temp;
            }

            //решение задачи
            if (x > a && x < b)//проверка внутри промежутка
            {
                Console.WriteLine("Число {0} внутри промежутка ({1}, {2})", x, a, b);
            } else if (x == a || x == b)//проверка на границе
            {
                Console.WriteLine($"Число {x} на границе промежутка ({a}, {b})");
            }else
            {
                Console.WriteLine($"Число {x} вне промежутка ({a}, {b})");
            }
            //--------------тернарный оператор ? : --------------------//
            //x = a > b ? a * a : b * b;
            //double max = a > b ? a : b;

            //-------------конструкция switch case-------------------//
            int foo = 2;
            switch (foo)
            {
                case 0:
                    Console.WriteLine("ноль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                default:
                    Console.WriteLine("Я еще не знаю таких цифр");
                    break;
            }*/
            //---------------------циклы-----------------//
            /*//зацикливание выполнения программы циклом с постусловием
            do
            {
                //Банковская система...цикл с предусловием
                Console.WriteLine("Добро пожаловать в систему БАНКОМАТ");
                int account = 200;//банковский счет в долларах
                while (account > 0)
                {
                    Console.WriteLine($"Доступно {account}$. Введите сумму для снятия: ");
                    int cash = Convert.ToInt32(Console.ReadLine());
                    account -= cash;
                }
                Console.WriteLine($"На счету осталось {account}$. ");
                Console.WriteLine("Желаете повторить запуск программы (+/-)?  ...");
            } while (Console.ReadKey().KeyChar == '+');
            Console.WriteLine("Всего хорошего!");*/

            //--------------------------цикл for--------------------------------//
            /*//вводится целое число
            //нужно определить, является ли число простым
            int number;
            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            bool isSimple=true;
            for(int i=2; i < number && isSimple; i++)
            {
                if (number % i == 0) isSimple = false;
            }
            if (isSimple)
                Console.WriteLine($"Число {number} простое");
            else
                Console.WriteLine($"Число {number} составное");*/


            //-------------------------МАССИВЫ--------------------------------//урок 2
            //набор однотипных данных, расположенных подряд в памяти, с доступом по индексу
            //ссылочный тип(передача по ссылке), класс Array, фиксированная длина, индексация с ноля

            /*//1.Объявление и выделение памяти для переменной массива
            int[] arr=new int [10]; 

            //2.Инициализация массива
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            //3.Выводим на экран
            foreach (int elem in arr)//переменная elem только для чтения
            //for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write($"{arr[i]} ");
                Console.Write($"{elem} ");
            }       
            Console.WriteLine();*/

            /*//Петя получил оценки за семестр по 8 предметам от 3 до 5, программа должна найти среднее арифметическое и количество каждой оценки
            
            //создание массива оценок
            int[] marks = new int[8];

            //заполнение оценок
            for(int i=0; i < marks.Length; i++)
            {
                Console.Write("Введите оценку: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            //вычисление среднего
            double avg = marks.Average();
            Console.Write("Средний балл Пети: {0}", avg);

            //подсчет к-ва разных оценок
            int[] countMarks = new int[marks.Max()+1];
            for(int i=0;i<countMarks.Length; i++)
            {
                countMarks[i] = marks.Count(elem => elem == i);
            }

            //вывод результатов рассчетов
            for (int i = 0; i < countMarks.Length; i++)
            {
                Console.WriteLine($"\nК-во оценок {i} =  {countMarks[i]}");
            }*/
            //св-во мутабельности - переменная является изменяемой

            /*//сохранение по ссылке
            int[] arr_1 = new int[] { 1, 2, 3 };
            int[] arr_2 = arr_1;
            arr_2[1] = 0;
            Console.WriteLine(arr_1[1]);

            //сохранение с глубоким копированием
            arr_1 = new int[] { -1, -2, -3 };
            arr_1.CopyTo(arr_2, 0);
            arr_2[0] = 0;
            Console.WriteLine(arr_1[0]);
            Console.WriteLine(arr_2[0]);*/

            //----------------------------МНОГОМЕРНЫЕ МАССИВЫ----------------------//
            //1.Прямоугольные и 2.Треугольные массивы
            /*//Прямоугольный двумерный массив
            //                            [стр,столбцы]
            int m = 3, n = 4;//записываем к-во строк и столбцов в переменные
            double[,] matrix = new double [3,4];
            
            //Инициализация двумерного массива
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = i * j * 0.1;
                }
            }

            //Вывод массива на экран
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"{ matrix[i, j]}");
                }
                Console.WriteLine();
            }

            //перебор и вывод через форыч
            foreach(var elem in matrix)
            {
                Console.WriteLine($"{ elem}");
            }
            Console.WriteLine();*/
            //-------------------------------
            //Треугольный двумерный массив (зубчатые)
            int[][] arr = new int[3][];//создано 3 пустые строки
            arr[0] = new int[1];
            arr[1] = new int[2];
            arr[2] = new int[3];

            for(int i=0; i< arr.Length; i++)
            {
                //Console.WriteLine(i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i - j - 10;
                    Console.WriteLine($"{arr[i][j]}");
                }
                Console.WriteLine();
            }

            //перебор и вывод форычем
            foreach(int[] str in arr)
            {
                foreach(int elem in str)
                {
                    Console.Write($"{elem}");
                }
                Console.WriteLine();
            }
        }
    }
}
