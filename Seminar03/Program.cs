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
            // Напишите программу, которая принимает на вход число (N) 
            // и выдаёт таблицу кубов чисел от 1 до N.
            // 3 -> 1, 8, 27
            // 5 -> 1, 8, 27, 64, 125

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int index = 1;
            while( index <= n)
            {
            int result1 = (int)Math.Pow((index), 3);
               Console.WriteLine(result1);
             index++;
            }
        break;
        case 2:
                // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                // 14212 -> нет
                // 12821 -> да
                // 23432 -> да

                Console.Write("Введите пятизначное число: ");
                string number = Console.ReadLine();
                int i = number.ToString().Length;
                if (i == 5)
                {
                  if(number[0] == number[4] && number[1] == number[3]) 
                  {
                    Console.WriteLine(number +" Это палиндром!");
                  }
                  else 
                  {
                    Console.WriteLine(number + " Это не палиндром!");
                  }

                }
                else
                {
                    Console.WriteLine("Не верное значение!"); 
                } 
             break;
            case 3:
                // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
                // A (3,6,8); B (2,1,-7), -> 15.84
                // A (7,-5, 0); B (1,-1,9) -> 11.53


                Console.WriteLine("Введите координаты точки A");
                Console.Write("Введите точку x: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.Write("Введите точку y: ");
                int y1 = int.Parse(Console.ReadLine());
                Console.Write("Введите точку z: ");
                int z1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты точки B");
                Console.Write("Введите точку x: ");
                int x2 = int.Parse(Console.ReadLine());
                Console.Write("Введите точку y: ");
                int y2 = int.Parse(Console.ReadLine());
                Console.Write("Введите точку z: ");
                int z2 = int.Parse(Console.ReadLine());


                double result = Math.Sqrt(Math.Pow((x2 - x1 ), 2) + Math.Pow((y2- y1), 2) + Math.Pow((z1 - z2), 2));
                Console.WriteLine($"{result}");
                break;
                 default:
            begin = false;
            break;
    }
}