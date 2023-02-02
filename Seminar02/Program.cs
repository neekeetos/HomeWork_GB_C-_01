int program;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Введите номер задачи от 1 до 3: ");
    program = int.Parse(Console.ReadLine());

    switch (program)
    {
        case 1:
        //  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

        Console.WriteLine("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        if(num < 999 + 1 && num > 98 + 1)
        { 
        int a = num % 100 / 10;
        Console.WriteLine(a);
        }
        else {
            Console.WriteLine("Вы ввели не верное занчение!");
        }
        Console.WriteLine("Конец первой задачи!");
            break;
        case 2:
        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


        Console.Write("Введите число:");
        int number = int.Parse(Console.ReadLine());
        int count = number.ToString().Length;
        Console.Write(MakeArray(number, count));
        int MakeArray(int a, int b)
        {
        int result = 0;
            if (b < 3)
            {
                Console.WriteLine("Третьей цифры нет ");
            }
            else
            {
                int c = 1;
                for (int i = b; i > 3; i--)
                {
                    c = c * 10;
                }

                result = (a / c) % 10;
                
            }
        return result;
        }
        
        break;

        case 3:
        //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            
            
            Console.WriteLine("Введите число дня недели от 1 до 7:  "); 
            int num1 = int.Parse(Console.ReadLine()); 
            if (num1 <= 7)
            {        
                    if (num1 <= 5) 
                    { 
                        Console.WriteLine("Это рабочий день!"); 
                    } 
                    else if (num1 > 5)
                    { 
                        Console.WriteLine("это выходной!"); 
                    } 
                }
            else Console.WriteLine(" Не существует такого дня недели");
            
            break;
            
        default:
            begin = false;
            break;
    }

}