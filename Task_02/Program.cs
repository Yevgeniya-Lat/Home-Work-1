int[] masiv = new int[5]{5,7,2,9,1};
Console.WriteLine("Длина массива:  " + masiv.Length);
Console.Write ("Массив до сортировки: ");
for(int i = 0; i<masiv.Length; i++)
    Console.Write(" " +masiv[i]);
Array.Sort(masiv);
Console.WriteLine();
Console.Write("Отсортированный массив:  ");
    for(int i=0; i<masiv.Length; i++)
Console.Write(" " +masiv[i]);
Console.ReadKey();
{
    
}
