



// Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Task_1();
Task_2();
Task_3();
void Task_1 ()
{
    int firstNumber = ReadInt("First number: ");
    int secondNumber = ReadInt("Second number: ");

    naturalDegree(firstNumber, secondNumber);
}

int ReadInt(string argument)
{
    Console.Write($"Imput {argument}");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a int");
    }

    return number;
}

void naturalDegree(int firstNumber, int secondNumber)
{   int i = 1;
     int exponentiation = firstNumber;
    while(i < secondNumber)
    {
        exponentiation = exponentiation * firstNumber;
        i++;
    }
    Console.WriteLine(exponentiation);
}

//  Напишите программу, которая принимает на вход число и выдаёт сумму
//   цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void Task_2()
{
int number = ReadInt("number: ");
sumNumber (number);
}

void sumNumber (int number)
{
   int sum = 0;
   while(number > 0)
   {
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
   }
   Console.WriteLine(sum);
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Task_3()
{
    int components = ReadInt("components: ");
    GetArray (components); 
}

void GetArray( int components)
{   
     int [] array = new int [components];
    for( int i = 0; i < components; i++ )
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + ", ");
    }
}  
  



