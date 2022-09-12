// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше нуля ввёл пользователь.
Console.WriteLine("Введите количество чисел M: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

for (int i = 0; i < size; i++)
{
   Console.Write($"Введите {i+1}  число: ");
   array [i] = Convert.ToInt32(Console.ReadLine());
}
    
int GetCount (int [] array)
{
    int count = 0;
    for (int i=0; i<size; i++)
    {
        if (array [i] > 0) count+=1;
    }
    return(count);
}

Console.WriteLine($"Чисел больше нуля: {GetCount(array)}");

