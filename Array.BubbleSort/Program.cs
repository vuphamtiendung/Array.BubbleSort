using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Input amount in the array");
        int amount = Convert.ToInt32(ReadLine());
        int[] array = new int[amount];
        int countArray = 0;

        WriteLine("Input data in the array");
        for(int index = 0; index < array.Length; index++)
        {
            array[index] = Convert.ToInt32(ReadLine());
        }

        WriteLine("Data before have bubble sort");
        foreach(var item in array)
        {
            WriteLine($"{item}");
        }

        for(int index = 0; index < array.Length; index++)
        {
            for (int indexTwo = index + 1; indexTwo < array.Length; indexTwo++)
            {
                if (array[index] > array[indexTwo])
                {
                    int temp = array[index];
                    array[index] = array[indexTwo];
                    array[indexTwo] = temp;
                }
            }
        }
        WriteLine("Array after have the bubble sort:");
        foreach (var item in array.Distinct())
        {
            
            WriteLine($"{item}");
        }
        ReadLine();
    }
}