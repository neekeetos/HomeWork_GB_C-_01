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
            Console.Write("Введите числа через запятую: ");
            int[] numbers = StringToNum(Console.ReadLine());
            PrintArray(numbers);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    sum++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"количество значений больше 0 = {sum}");


            int[] StringToNum(string input)
            {
                int count = 1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ',')
                    {
                        count++;
                    }
                }

                int[] numbers = new int [count];
                int index = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    string temp = "";

                    while (input [i] != ',')
                    {
                    if(i != input.Length - 1)
                    {
                        temp += input [i].ToString();
                        i++;
                    }
                    else
                    {
                        temp += input [i].ToString();
                        break;
                    }
                    }
                    numbers[index] = Convert.ToInt32(temp);
                    index++;
                }
                return numbers;
            }


            void PrintArray(int[] array)
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            break;
            case 2:
                Console.WriteLine("введите значение b1");
                double b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите число k1");
                double k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите значение b2");
                double b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите число k2");
                double k2 = Convert.ToInt32(Console.ReadLine());

                double x = (-b2 + b1)/(-k1 + k2);
                double y = k2 * x + b2;

                Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
            break;
         default:
                
         begin = false;
      break;
      }
 }