int program;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("_____________________");
    Console.WriteLine("Введите номер задачи от 1 до 4: ");
    program = int.Parse(Console.ReadLine());

    switch (program)
    {
        case 1:
            Console.WriteLine("1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. ");
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Первое число " + a + " больше, чем второе " + b + "!");
            }
            else
            {
                Console.WriteLine("Второе число " + b + " больше, чем " + a + "!");
            }
            Console.WriteLine("Конец первой задачи!");
                        
            break;

        case 2:
            Console.WriteLine("2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. ");
            Console.WriteLine("Введите три числа:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            int max = c;

            if (d > max) { max = d; }
            if (f > max) { max = f; }

            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Конец второй задачи!");
            break;
            // 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка)
            
        case 3:
            Console.WriteLine("3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка) ");
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Это число чётное " + n);
            }
            else
            {
                Console.WriteLine("Это число нечётное " + n);
            }
            
            Console.WriteLine("Конец задачи!");
            break;

        case 4:
            Console.WriteLine("4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. ");
            Console.WriteLine("Введите число: ");
            int num1 = int.Parse(Console.ReadLine());

            int res = 1;
            while (res < num1)
            {
                Console.WriteLine(res + 1);
                res += 2;
            }
            Console.WriteLine("Конец задачи!");
            break;

        default:
            begin = false;
            break;
    }

}
