int program;
Boolean begin = true;

while(begin)
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Введите номер задачи от 1 до 2: ");
    program = int.Parse(Console.ReadLine());

    switch (program)
    {
        case 1:  

            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);

            void FillArrayRandomNumbers(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                    }
                }
            }

            void PrintArray(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
             break;
             case 2:

                    Console.WriteLine("введите номер строки");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("введите номер столбца");
                    int m = Convert.ToInt32(Console.ReadLine());
                    int [,] num = new int [10,10];
                    FillArrayRandomNumbers(num);

                    if (n > num.GetLength(0) || m > num.GetLength(1))
                    {
                        Console.WriteLine("такого элемента нет");
                    }
                    else
                    {
                        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {num[n-1,m-1]}");
                    }

                    PrintArray(num);

                    void FillArrayRandomNumbers(int[,] array)
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                            {        
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array [i,j] = new Random().Next(-100, 100)/10;
                                }   
                            }
                    }

                    void PrintArray(int[,] array)
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            Console.Write("[ ");
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write(array[i,j] + " ");
                            }   
                            Console.Write("]");
                            Console.WriteLine(""); 
                        }
                    }
                     break;
                     case 3:
                        Console.WriteLine("введите количество строк");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("введите количество столбцов");
                        int m = Convert.ToInt32(Console.ReadLine());

                        int[,] numbers = new int[n, m];
                        FillArrayRandomNumbers(numbers);


                        for (int j = 0; j < numbers.GetLength(1); j++)
                        {
                            double avarage = 0;
                            for (int i = 0; i < numbers.GetLength(0); i++)
                            {
                                avarage = (avarage + numbers[i, j]);
                            }
                            avarage = avarage / n;
                            Console.Write(avarage + "; ");
                        }
                        Console.WriteLine();
                        PrintArray(numbers);



                        void FillArrayRandomNumbers(int[,] array)
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    array[i, j] = new Random().Next(0, 10);
                                }
                            }
                        }

                        void PrintArray(int[,] array)
                        {

                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                Console.Write("[ ");
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    Console.Write(array[i, j] + " ");
                                }
                                Console.Write("]");
                                Console.WriteLine("");
                            }
                        }
                        break;
                         default:
                
         begin = false;
      break;
      }
 }
