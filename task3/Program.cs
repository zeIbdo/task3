namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ters array
            //int[] numbers = { 2, 5,9, 8, 9 };
            //int temp = 0;
            //Console.WriteLine("Array: ");
            //for (int k = 0; k < numbers.Length; k++)
            //{
            //    Console.WriteLine(numbers[k]);
            //}
            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = temp;


            //}
            //Console.WriteLine("array after change: ");
            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    Console.WriteLine(numbers[j]);
            //}
            #endregion
            #region duplicate detector
            //int[] prices = { 9888, 9888, 123, 56, 23, 87 };
            //bool isDuplicate = false;
            //for (int i = 1; i < prices.Length; i++)
            //{
            //    if (prices[i] == prices[i - 1])
            //        isDuplicate = true;
            //}
            //if (isDuplicate)
            //    Console.WriteLine("array daxilinde duplicate var");
            //else { Console.WriteLine("duplicate yoxdur"); }
            #endregion
            #region subset detector
            int[] prices = { 5,5 };
            int[] discounts = { 5 };
            bool isSubset = true;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j < discounts.Length; j++)
                {
                    if (prices[i] == discounts[j])
                    {
                        isSubset = true;
                        break;
                    }
                    else if (prices[i] != discounts[j])
                        isSubset = false;
                }
                if (isSubset == false) { break; }
            }
            if (isSubset == true)
            {
                Console.WriteLine("Prices array is subset of discounts array");
            }
            else
                Console.WriteLine("Prices array is not subset of discounts array");
            #endregion
        }
    }
}
