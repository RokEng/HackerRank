//https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum/problem

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void MiniMaxSum(List<int> arr)
    {
        //get highest and lowest value from List arr
        long highestValue = arr.Max();
        long lowestValue = arr.Min();

        //we can calculate the sum of all elements in the list 
        //remove lowest value from it to get the highest sum of 4 numbers
        //remove highest value from it to get lowest sum of 4 numbers
        //have to convert numbers to int64 or it'll throw an exception at higher numbers
        long highestSum = arr.Sum(num => Convert.ToInt64(num)) - lowestValue;
        long lowestSum = arr.Sum(num => Convert.ToInt64(num)) - highestValue;

        //print results
        Console.WriteLine(lowestSum + " " + highestSum);
    }

}

class Solution
{
    public static void Main()
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.MiniMaxSum(arr);
    }
}