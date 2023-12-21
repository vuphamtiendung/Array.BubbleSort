using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine($"Input amount in the array");
        int amount = Convert.ToInt32(ReadLine());
        int[] array = new int[amount];

        WriteLine("Input data in the array");
        for(int index = 0; index < array.Length; index++)
        {
            array[index] = Convert.ToInt32(ReadLine());
        }

        foreach(var item in array)
        {
            WriteLine($"Array before in the swap: {item}");
        }

        for(int index = 0; index < array.Length; index++)
        {
            for(int indexTwo = index + 1; indexTwo < array.Length; indexTwo++)
            {
                if (array[index] > array[indexTwo])
                {
                    int temp = array[index];
                    array[index] = array[indexTwo];
                    array[indexTwo] = temp;
                }
            }
        }

        foreach(var item in array)
        {
            WriteLine($"Array after in the swap: {item}");
        }

        ReadLine();
    }
}