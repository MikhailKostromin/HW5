// Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход число любой 
// размерности и проверяет, является ли оно палиндромом.


Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
long result=0;
result = ViceVersa(number);

//написать функцию палиндрома

long ViceVersa (long count)
{
    while(count>0)
    {
        result *= 10;
        result += count % 10;
        count /=10;
    }
    return result;
}

void Palindrome()
{
    if (number==result)
    {
        Console.WriteLine("Число  " + number + "   является палиндромом" );
    }
    else Console.WriteLine("Число  " + number + "  не является палиндромом" );
    
}
Palindrome();