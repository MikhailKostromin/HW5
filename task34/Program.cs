// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int N=new Random().Next(0,10);
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)     // создал массив
{
    array[i] = new Random().Next(100,999);         // в Next (можно указать из каких цифр)
}
void PrintArray (int[] array)
{
Console.Write("[");                     //Красиво печатаем массив
for (int i = 0; i < N - 1; ++i)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine(array[N - 1] + "]");
}
PrintArray(array);

void Count (int [] array)
{
int C=0;    
for (int i = 0; i < array.Length; i++)     // Проверка на четность
{
    if (array[i]%2==0)
    {
        C=C+1;
    }       
}
Console.WriteLine($"Количество чётных чисел в массиве = {C}");
}
Count(array);