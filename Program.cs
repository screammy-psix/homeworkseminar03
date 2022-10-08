//Задача 19
//Напишите метод, который принимает на вход 
//пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Zadanie19()
{
    Console.WriteLine("Введите 5ти значное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int current_number = number;
    if (number > 9999 && number<100000)
    {
        Console.WriteLine($"молодец, ввел 5 циферок");
    }
    else
    {
        Console.WriteLine("что-то пошло не так, попробуй еще раз");
    }
while (current_number > 0)
    {   
        int digit = current_number % 10;
        result = result *10 + digit;
        current_number /= 10;
        Console.WriteLine(result);
    }
    if (number == result)
    {
        Console.WriteLine($"число палиндром");
    }
    else
    {
        Console.WriteLine($"число {number} не палиндром");
    }
}

//Задача 21
//Напишите метод, который принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53    
void Zadanie21()

{
    Console.WriteLine("Введите коорнаты точки А: ");
    Console.WriteLine("X: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коорнаты точки B: ");
    Console.WriteLine("X: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Z: ");
    int bz = Convert.ToInt32(Console.ReadLine());
    
    double result = Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2)+ Math.Pow(az-bz, 2));
    
    Console.WriteLine($"Длина {result}");
}


//Задача 23
//Напишите метод, который принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void Zadanie23()
{
     Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double Sqw;
    while (i<= N)
    {
        Sqw = Math.Pow(i,3);
        Console.WriteLine($"Дано число {i}, которое в кубе = {Sqw}");
        i++; 
    }
}
Zadanie23();
