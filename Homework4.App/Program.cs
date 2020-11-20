using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            bool repeat = true;
            do
            {
                int choice = Choice();
                if (choice == 1)
                {
                    MatrixSum();
                }
                if (choice == 2)
                {
                    MatrixOnNumber();
                }
                if (choice == 3)
                {
                    MatrixOnMatrix();
                }
                if (choice == 4)
                {
                    MatrixExp();
                }
                if (choice == 5)
                {
                    Transponention();
                }
                Repeat(repeat);
            } while (repeat);
            
            

        }
    
        static int Choice()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Эта программа позволяет производить операции над матрицами");
                Console.WriteLine("Какую операцию вы хотите осущесвить?");
                Console.WriteLine("");
                Console.WriteLine("1 - сложение матриц");
                Console.WriteLine("");
                Console.WriteLine("2 - умножение матрицы на число");
                Console.WriteLine("");
                Console.WriteLine("3 - умножение матриц");
                Console.WriteLine("");
                Console.WriteLine("4 - возведение матрицы в степень");
                Console.WriteLine("");
                Console.WriteLine("5 - транспонирование матриц");
                choice = NumberInput();
            } while (choice < 1 || choice > 5);
            return choice;
        }
        static int Size()
        {
            bool result = false;
            int size = 0;
            while (result == false)
            {
                result = int.TryParse(Console.ReadLine(), out size);
                if (result == true)
                {
                    if (size < 2)
                    {
                        Console.WriteLine("Нужно ввести число не меньше 2");
                        result = false;
                        continue;
                    }
                    else if (size > 10)
                    {
                        Console.WriteLine("Нужен ввеси число не больше 10");
                        result = false;
                        continue;
                    }
                    else continue;
                }
                else continue;
            }
            return size;
        }
        static int NumberInput()
        {
            bool result2 = false;
            int number = 0;
            while (result2 == false)
            {
                result2 = int.TryParse(Console.ReadLine(), out number);
                if (result2 == false)
                {
                    Console.WriteLine("Вы ввели не число или число с плавающей точкой!");
                    continue;
                }
            }
            Console.Clear();
            return number;
        }
        static void WriteMatrix(int rows, int columns, int[,] matrixresult)
        {
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {

                    Console.Write("{0}\t", matrixresult[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MatrixSum()
        {
            Console.WriteLine("Введите колличество строк в первой матрице");
            int rows1 = Size();
            Console.WriteLine("Введите колличество столбцов в первой матрице");
            int columns1 = Size();
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; rows1 > i; i++)
            {
                for (int j = 0; columns1 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            Console.WriteLine("Вторая матрица будет иметь такую же размерность, как и первая, иначе сложение невозможно");
            int rows2 = rows1;
            int columns2 = rows1;
            int[,] matrix2 = new int[rows2, columns2];
            for (int i = 0; rows2 > i; i++)
            {
                for (int j = 0; columns2 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix2[i, j] = NumberInput();
                }
            }
            int rows = rows1;
            int columns = columns1;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    matrixresult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            WriteMatrix(rows, columns, matrixresult);
        }
        static void MatrixOnNumber()
        {
            Console.WriteLine("Введите колличество строк в матрице");
            int rows1 = Size();
            Console.WriteLine("Введите колличество столбцов в матрице");
            int columns1 = Size();
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; rows1 > i; i++)
            {
                for (int j = 0; columns1 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            Console.WriteLine("Введите число, на которое нужно умножить матрицу");
            int number = NumberInput();
            int rows = rows1;
            int columns = columns1;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    matrixresult[i, j] = matrix1[i, j] *number;
                }
            }
            WriteMatrix(rows, columns, matrixresult);
        }
        static void MatrixOnMatrix()
        {
            Console.WriteLine("Введите колличество строк в первой матрице");
            int rows1 = Size();
            Console.WriteLine("Введите колличество столбцов в первой матрице");
            int columns1 = Size();
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; rows1 > i; i++)
            {
                for (int j = 0; columns1 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            Console.WriteLine("Вторая матрица будет иметь столько же столбцов, сколько строк в первой");
            int columns2 = rows1;
            Console.WriteLine("Введите колличество строк во второй матрице");
            int rows2 = Size();
            int[,] matrix2 = new int[rows2, columns2];
            for (int i = 0; rows2 > i; i++)
            {
                for (int j = 0; columns2 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix2[i, j] = NumberInput();
                }
            }
            int rows = rows2;
            int columns = columns1;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    for (int k = 0; rows2 > k; k++)
                    {
                        matrixresult[i, j] = matrixresult[i, j] + matrix1[k, i] * matrix2[j, k];
                    }
                }
            }
            WriteMatrix(rows, columns, matrixresult);
        }
        static void MatrixExp()
        {
            Console.WriteLine("Введите колличество строк в матрице");
            int rows1 = Size();
            Console.WriteLine("Введите колличество столбцов в матрице");
            int columns1 = Size();
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; rows1 > i; i++)
            {
                for (int j = 0; columns1 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            Console.WriteLine("Введите степень, в которую нужно возвести матрицу");
            int exponent = NumberInput();
            int rows = rows1;
            int columns = columns1;
            int[,] matrixresult = new int[rows, columns];
            for(int n=0; exponent > n; n++)
            {
                for (int i = 0; rows > i; i++)
                {
                    for (int j = 0; columns > j; j++)
                    {
                        for (int k = 0; rows1 > k; k++)
                        {
                            matrixresult[i, j] = matrixresult[i, k] * matrix1[k, j];
                        }
                    }
                }
            }
            
            WriteMatrix(rows, columns, matrixresult);
        }
        static void Transponention()
        {
            Console.WriteLine("Введите колличество строк в матрице");
            int rows1 = Size();
            Console.WriteLine("Введите колличество столбцов в матрице");
            int columns1 = Size();
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; rows1 > i; i++)
            {
                for (int j = 0; columns1 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            
            int rows = columns1;
            int columns = rows1;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    matrixresult[i, j] = matrix1[j, i];
                }
            }
            WriteMatrix(rows, columns, matrixresult);
        }
        static bool Repeat(bool repeat)
        {
            bool repeat2 = true;
            do
            {
                Console.WriteLine("Хотите ли продолжить работу с программой? д/н");
                string repeatchar = Console.ReadLine();
                if (repeatchar == "д")
                {
                    repeat = true;
                    repeat2 = false;
                }
                else if (repeatchar == "н")
                {
                    repeat = false;
                    repeat2 = false;
                }
                else
                {
                    Console.WriteLine("Ответьте 'д' или 'н'");
                    repeat2 = true;
                }
            }
            while (repeat2);
            return repeat;
            
        }
 
        
    }
}