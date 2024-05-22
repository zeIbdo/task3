namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ters array
            int[] numbers = { 2, 5, 8, 9 };
            int temp = 0;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;


            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }
            #endregion
        }
    }
}
