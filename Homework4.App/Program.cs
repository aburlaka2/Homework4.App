using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            bool repeat = true;
            while (repeat)
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
                repeat=Repeat();
            }
            
            

        }
    
        static int Choice()
        {
            int choice;
            do
            {
                Console.Clear();
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
            Console.Clear();
            Console.WriteLine("Введите колличество строк в первой матрице");
            int rows = Size();
            Console.WriteLine("Введите колличество столбцов в первой матрице");
            int columns = Size();
            int[,] matrix1 = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix1[i, j] = NumberInput();
                }
            }
            Console.Clear();
            Console.WriteLine("Вторая матрица будет иметь такую же размерность, как и первая, иначе сложение невозможно");
            int[,] matrix2 = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    Console.WriteLine("Введите значение элемента второй матрицы " + (i + 1) + "," + (j + 1));
                    matrix2[i, j] = NumberInput();
                }
            }
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    matrixresult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.Clear();
            WriteMatrix(rows, columns, matrixresult);
        }
        static void MatrixOnNumber()
        {
            Console.Clear();
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
            Console.Clear();
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
            Console.Clear();
            WriteMatrix(rows, columns, matrixresult);
        }
        static void MatrixOnMatrix()
        {
            Console.Clear();
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
            Console.Clear();
            Console.WriteLine("Введите колличество строк во второй матрице");
            int rows2 = Size();
            Console.WriteLine("Введите колличество столбцов во второй матрице");
            int columns2 = Size();
            int[,] matrix2 = new int[rows2, columns2];
            for (int i = 0; rows2 > i; i++)
            {
                for (int j = 0; columns2 > j; j++)
                {
                    Console.WriteLine("Введите значение элемента первой матрицы " + (i + 1) + "," + (j + 1));
                    matrix2[i, j] = NumberInput();
                }
            }
            if (rows1 == columns2 && rows2 != columns1)
            {
                Console.Clear();
                Console.WriteLine("Возможно умножение первой матрицы на вторую");
                Console.WriteLine("Результат");
                Matrix1OnMatrix2(rows1, rows2, columns2, matrix1, matrix2);
            }
            else if (rows1 != columns2 && rows2 == columns1)
            {
                Console.Clear();
                Console.WriteLine("Возможно умножение второй матрицы на первую");
                Console.WriteLine("Результат");
                Matrix2OnMatrix1(rows1, columns1, rows2, matrix1, matrix2);
            }
            else if (rows1 == columns2 && rows2 == columns1)
            {
                Console.Clear();
                Console.WriteLine("Возможы два варианта умножения");
                Console.WriteLine("Результат умножения первой матрицы на вторую");
                Matrix1OnMatrix2(rows1, rows2, columns2, matrix1, matrix2);
                Console.WriteLine("Результат умножения второй матрицы на первую");
                Matrix2OnMatrix1(rows1, columns1, rows2, matrix1, matrix2);
            }
            else Console.WriteLine("Умножение матриц невозможно");
        }
        static void Matrix1OnMatrix2(int rows1, int rows2, int columns2,int[,]matrix1, int[,] matrix2)
        {
            int rows = rows1;
            int columns = columns2;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    for (int k = 0; rows2 > k; k++)
                    {
                        matrixresult[i, j] = matrixresult[i, j] + matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            WriteMatrix(rows, columns, matrixresult);
        }
        static void Matrix2OnMatrix1(int rows1, int columns1, int rows2, int[,] matrix1, int[,] matrix2)
        {
            int rows = rows2;
            int columns = columns1;
            int[,] matrixresult = new int[rows, columns];
            for (int i = 0; rows > i; i++)
            {
                for (int j = 0; columns > j; j++)
                {
                    for (int k = 0; rows1 > k; k++)
                    {
                        matrixresult[i, j] = matrixresult[i, j] + matrix2[i, k] * matrix1[k, j];
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
            int[,] matrixresult2 = new int[rows, columns];
            for (int n=1; exponent > n; n++)
            {
                for (int i = 0; rows > i; i++)
                {
                    for (int j = 0; columns > j; j++)
                    {
                        for (int k = 0; rows1 > k; k++)
                        {
                            if (n == 1)
                            {
                                matrixresult[i, k] = matrix1[i,k];
                            }
                            matrixresult2[i, j] = matrixresult2[i, j] + matrixresult[i, k] * matrix1[k, j];
                        }
                        matrixresult[i, j] = matrixresult2[i, j];

                    }

                }
            }
            Console.Clear();
            WriteMatrix(rows, columns, matrixresult2);
        }
        static void Transponention()
        {
            Console.Clear();
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
            Console.Clear();
            WriteMatrix(rows, columns, matrixresult);
        }
        static bool Repeat()
        {
            bool repeat;
            bool repeat2;
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
                    repeat = true;
                    repeat2 = true;
                }
            }
            while (repeat2);
            return repeat;
            
        }
 
        
    }
}