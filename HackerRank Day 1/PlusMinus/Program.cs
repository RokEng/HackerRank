class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void PlusMinus(List<int> arr)
    {
        //dictionary makes saving values easy, keys are for positives, negatives and zeros 
        //whenever a number is positive, we increase value of the key by 1, same for negative numbers
        //and zeros
        Dictionary<string, int> dict = new()
        {
            { "positives", 0 },
            { "negatives", 0 },
            { "zeros", 0 }
        };

        //looping through the whole list arr, increasing values in dictionary dict
        foreach (int elem in arr)
        {
            if (elem > 0)
            {
                dict["positives"] += 1;
            }
            else if (elem < 0)
            {
                dict["negatives"] += 1;
            }
            else
            {
                dict["zeros"] += 1;
            }
        }

        //calculating the ratio and printing the result, changing value to double because we need it
        //for dividing (dividing ints results in 0) 
        foreach (int item in dict.Values)
        {
            double ratio = Math.Round((double)item / arr.Count, 6);
            //formatting, for trailing zeros in ratio 
            Console.WriteLine(ratio.ToString("0.000000"));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}
