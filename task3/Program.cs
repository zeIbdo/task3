namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ters array
            //int[] numbers = { 2, 5, 8, 9 };
            //int temp = 0;
            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = temp;


            //}
            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    Console.WriteLine(numbers[j]);
            //}
            #endregion
            #region duplicate detector
            int[] prices = { 9888, 9898, 123, 56, 23, 87 };
            bool isDuplicate = false;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] == prices[i - 1])
                    isDuplicate = true;
            }
            if (isDuplicate)
                Console.WriteLine("array daxilinde duplicate var");
            else { Console.WriteLine("duplicate yoxdur"); }
            #endregion
        }
    }
}
