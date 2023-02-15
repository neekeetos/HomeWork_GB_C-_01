int program;
Boolean begin = true;

while(begin)
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Введите номер задачи от 1 до 3: ");
    program = int.Parse(Console.ReadLine());

    switch (program)
    {
        case 1:  
        // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
        //             [345, 897, 568, 234] -> 2
            Console.WriteLine("Введите длину массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[size];
            RandonNumbers(number);
            PrintArray(number);
            Console.WriteLine();

            void RandonNumbers(int[] number)
            {
                for(int i = 0; i < size; i++)
                    {
                        number[i] = new Random().Next(100, 1000);
                    }
            }

                int count = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] % 2 == 0)
                        count++;
                }
                    Console.WriteLine($"Количество четных чисел в массиве: {count}");


            void PrintArray(int[] numbers)
            {
                for(int i = 0; i < number.Length; i++)
                {
                    Console.Write(number[i] + ", ");
                }
            }
        break;

        case 2:
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
            // [-4, -6, 89, 6] -> 0

            Console.WriteLine("Введите размер массива  ");
            int sizeNew = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[sizeNew];
            FillArrayRandomNumbers(numbers);
            PrintNewArray(numbers);
            int sum = 0;

            for (int z = 0; z < numbers.Length; z+=2)
                sum = sum + numbers[z];

                Console.WriteLine($"Cумма нечетных элементов = {sum}");

            void FillArrayRandomNumbers(int[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = new Random().Next(-10, 100);
                    }
            }
            void PrintNewArray(int[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                
                Console.WriteLine();
            }
        break;

        case 3:
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            // [3 7 22 2 78] -> 76

            Console.Write("Введите размер массива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] numbersNew = new int[size1];
            ArrayRandomNumbers(numbersNew);
            PrintArrayNumber(numbersNew);
            
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            for (int z = 0; z < numbersNew.Length; z++)
            {
                if (numbersNew[z] > max)
                    {
                        max = numbersNew[z];
                    }
                if (numbersNew[z] < min)
                    {
                        min = numbersNew[z];
                    }
            }

            Console.WriteLine($"всего {numbersNew.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

            void ArrayRandomNumbers(int[] numbersNew)
            {
                for(int i = 0; i < numbersNew.Length; i++)
                    {
                         numbersNew[i] = Convert.ToInt32(new Random().Next(1, 100)) ;
                        //  / 100;
                    }
            }
            void PrintArrayNumber(int[] numbersNew)
            {
                for(int i = 0; i < numbersNew.Length; i++)
                    {
                        Console.Write(numbersNew[i] + ", ");
                    }
                
                Console.WriteLine();
            }
    
        break;
        default:
    
    begin = false;
    break;
    }
}