//Task3
//Сложность квадратичная
//Insertion Sort

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int t = 0; t < numbers.Length; t++)
{
    Console.Write($"{numbers[t]}\t");
}// Вывод массива
Console.WriteLine(); ;

for (int i = 1; i < numbers.Length; i++)
{
    int j =  i - 1;
    while (j >= 0 && numbers[j] > numbers[j+1])
    {
        int Temp = numbers[j];
        numbers[j] = numbers[j+1];
        numbers[j+1] = Temp;
        j--;    
    }
    
  
    for (int t = 0; t < numbers.Length; t++)
    {
        Console.Write($"{numbers[t]}\t");
    }// Вывод массива
    Console.WriteLine();
}