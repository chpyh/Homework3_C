int[] FillArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i ++)
{
array[i]= new Random().Next(1, 100);
}
 return array;
}
void PrintArr(int[] numbers)
{
    for(int index = 0; index < numbers.Length; index ++)
    {
    Console.Write(numbers[index] + " ");
    }
    Console.WriteLine();
}
void FindAmmount(int[] collection)
{
    int ammount = 0;
    foreach(int element in collection)
    {
        if(element % 2 == 0)
        {
              ammount++;
        }
    }
    Console.WriteLine(ammount);
}
int sizeArr = 10;
int[] arr = FillArray(sizeArr);
PrintArr(arr);
FindAmmount(arr);







