// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int N=new Random().Next(0,10);
int[]array = new int[N];
for (int i = 0; i < array.Length; i++)     // создал массив
{
    array[i] = new Random().Next(-1000,1000);         // в Next (можно указать из каких цифр)
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

void CountSum (int [] array)
{
int sum=0;    
for (int i = 0; i < array.Length; i++)     // сумма нечетных позиций
{
    if (i%2==1)
    {
        sum=sum+array[i];
    }       
}
Console.WriteLine($"Cумма нечетных позиций = {sum}");
}
CountSum(array);