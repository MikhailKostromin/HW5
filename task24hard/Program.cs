// Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и 
// находит расстояние между ними в N-мерном пространстве.
// N - задается пользователем.


string getDistance() 
{     
Console.Write("Введите количество пространств: ");
double number = Convert.ToInt32(Console.ReadLine());
double i = 1;
double result=0;
double sum =0;
    while ( i <= number) 
    {
    Console.WriteLine($"Введите {i} координату  точки А");     
     double A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите {i} координату  точки B");     
     double B = Convert.ToInt32(Console.ReadLine());  
     result=Math.Pow(A-B,2);
     sum = result+sum;
     i++;
    }
    
   double distance = Math.Round(Math.Sqrt(sum), 2);     
   return $"расстояние между двумя точками в {number} пространстве {distance} "; 
} 

    try 
{    
    Console.WriteLine(getDistance()); 
} 
    catch 
{     
    Console.WriteLine("Необходимо вводить коортинаты целыми числами");     
 }