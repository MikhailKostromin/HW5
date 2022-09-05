// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int N=new Random().Next(0,10);
double[]array = new double[N];
for (int i = 0; i < array.Length; i++)     // создал массив
{
    array[i] = new Random().Next(-10,10)+new Random().NextDouble();;         // в Next (можно указать из каких цифр)
}
void PrintArray (double[] array)
{
Console.Write("[");                     //Красиво печатаем массив
for (int i = 0; i < N - 1; ++i)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[N - 1] + "]");
}
PrintArray(array);
      
void FindMinMax(double[] array)  // Поиск Макс и Мин значений

{    
     double max = array[0];          
     double min = array[0];     
     for (int i = 0; i < array.Length; i++)     
     {         
        if (max<array[i])         
    {             
        max = array[i];                     
    }         
    if (min>array[i])         
    {             
        min = array[i];                           
    }     
    }
    double razElem = max-min; 
    Console.WriteLine($"\nМаксимальный элемент списка = {max}.\nМинимальный элемент = {min}.\nРазница = {razElem}");
}
     FindMinMax(array);