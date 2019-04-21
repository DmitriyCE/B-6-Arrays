using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Practice
    {
        public static void B6_P2_6_3DMassiveMaxInRow()
        {
            int[,] mass = new int[3, 3] { { 5, 67, 68 }, { 12, 6, 2 }, { 9, 11, 3 } };
            for (int i = 0; i < 3; i++)
            {
                int a = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j] > a)
                    {
                        a = mass[i, j];
                    }
                }
                Console.WriteLine(a);

            }

        }
        public static void MasiveSort()
        {
            //int[] mass = new int[] {5,8,4,7,3};
            Console.WriteLine("Укажите размер массива");
            int sizeMass = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[sizeMass];
            Console.WriteLine("Введите массив");
            for (int i = 0; i < sizeMass; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1 - i; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int tmp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = tmp;
                    }
                }


            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }


        }
       
        public static void Pyatnashki()
        {
            int[,] mass = new int[3, 3];
            initmass(mass);
            printmass(mass);
            while(true)
            {
                replaceVolumeMass(mass);
                printmass(mass);
            }
            
        }
        static Random rand = new Random();
        private static void initmass(int[,] mass)
        { 
            for (int i = 0; i < 3; i++)
            {
               for (int j = 0; j < 3; j++)
               {
                  mass[i, j] = rand.Next(1, 9);
               }

            }
            mass[1, 1] = 0;
        }
        private static void printmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private static void replaceVolumeMass(int[,] mass)
        {
            int[] positionNull = new int[2];
            // поиск расположения нуля в мартице
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i,j]==0)
                    {
                        positionNull[0] = i;
                        positionNull[1] = j;
                    }
                }
            }
            Console.WriteLine("Для перемещения управляющего элемента используйте клавищи 'wasd'");
            string select = Console.ReadLine();
            switch(select)
            {
                case "w":
                    {
                        if (positionNull[0] > 0)
                        {
                            int tmp = mass[positionNull[0] - 1 , positionNull[1]];
                            mass[positionNull[0] - 1, positionNull[1]] = 0;
                            mass[positionNull[0], positionNull[1]] = tmp;
                        }
                        break;
                    }
                case "s":
                    {
                        if (positionNull[0] < 2)
                        {
                            int tmp = mass[positionNull[0] + 1, positionNull[1]];
                            mass[positionNull[0] + 1, positionNull[1]] = 0;
                            mass[positionNull[0], positionNull[1]] = tmp;
                        }
                        break;
                    }
                case "a":
                    {
                        if (positionNull[1] > 0)
                        {
                            int tmp = mass[positionNull[0], positionNull[1]-1];
                            mass[positionNull[0], positionNull[1]-1] = 0;
                            mass[positionNull[0], positionNull[1]] = tmp;
                        }
                        break;
                    }
                case "d":
                    {
                        if (positionNull[1] < 2)
                        {
                            int tmp = mass[positionNull[0], positionNull[1] + 1];
                            mass[positionNull[0], positionNull[1] + 1] = 0;
                            mass[positionNull[0], positionNull[1]] = tmp;
                        }
                        break;
                    }
            }
        }
        public static void CutString()
        {
            Console.WriteLine("Введи предложение");
            string str = Console.ReadLine();
            int countLetters = str.Length;
            if (countLetters>13)
            {
                for (int i = 0; i < 13; i++)
                {
                    Console.Write(str[i]);
                }
                Console.Write("...");
            }

        }
        public static void ReplaceInPoem()
        {
            Console.WriteLine("Введите стихотворение построчно отделяя строки ';'");
            string str = Console.ReadLine();
            string[] massString = str.Split(';');
            //int lenghtmass = massString.Length;
            //Console.WriteLine(lenghtmass);
            for (int i = 0; i < massString.Length; i++)
            {
                massString[i] = massString[i].Replace('О', 'А');
                massString[i] = massString[i].Replace("Л", "ЛЬ");
                massString[i] = massString[i].Replace("ТЬ", "Т");
                Console.WriteLine(massString[i]);
            }

        }
    }    
}
