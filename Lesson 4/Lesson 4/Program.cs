using System;
using System.IO;

namespace Lesson_4
{
    class Program
    {
        static void Main()
        {



            //Task1();
            //Task2();
            //Inverse();
            //Multy();


            Console.ReadKey();
        }


        public static void Task1()
        {


            int[] arr = new int[20];
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                arr[i] = rand.Next(-10000, 10000);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < 20 - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", arr[i], arr[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
        }
        public static int Task2()
        {
            int sum = 0;
            Console.WriteLine("Введите размер массива с учетом 0 ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг массива ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i += m)
            {
                arr[i] = rand.Next(-100, 100);
                Console.WriteLine(arr[i] + " ");
                sum = arr[i] + sum;
                Console.WriteLine("Сумма на " + i + " шагу = " + sum);
            }

            return sum;
        }
        public static void Inverse()
        {
            int[] arr = new int[20];
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                arr[i] = rand.Next(-10000, 10000);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {

                Console.Write((arr[i] * -1) + " ");

            }
        }
        public static void Multy()
        {

            Console.WriteLine("Введите число на которое будет умножаться каждое число массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[20];
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                arr[i] = rand.Next(-10000, 10000);
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write((arr[i] * n) + " ");
            }
        }

    }
    }
