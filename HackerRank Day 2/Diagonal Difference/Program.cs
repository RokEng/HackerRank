class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int firstDiagonal = 0;
        //first diagonal - the one thing numbers in this diagonal have in common - arr[first][second] - first and second are the same number
        for (int i = 0; i < arr.Count; i++)
        {
            firstDiagonal += arr[i][i];
        }

        int secondDiagonal = 0;
        int startingNum = arr.Count - 1;
        //second diagonal - starts with 0 as [first], then continues increasing by 1, while [second] starts at highest and decreases by 1
        for (int j = 0; j < arr.Count; j++)
        {
            Console.WriteLine("Starting num: {0}", startingNum);
            Console.WriteLine("arr[j][startingNum]: {0}" , arr[j][startingNum]);
            secondDiagonal += arr[j][startingNum];
            startingNum--;
        }

        return Math.Abs(firstDiagonal - secondDiagonal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        //HackerRank code

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
