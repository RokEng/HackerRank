//https://www.hackerrank.com/challenges/one-week-preparation-kit-countingsort1/problem
class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arr)
    {
        //create new list, size needs to be 100, fill it up zeros
        List<int> newList = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            newList.Add(0);
        }

        //loop through the original list, increase newList[currentelement] by 1
        foreach (int num in arr)
        {
            newList[num]++;
        }

        return newList;
    }

}

class Solution
{
    //code from hackerRank
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        Console.WriteLine(String.Join(" ", result));

    }
}