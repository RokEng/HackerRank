//https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/problem
//method to find unique integer
static int lonelyinteger(List<int> a)
{
    //creating variable for result and dictionary to keep valuees
    int result = 0;
    Dictionary<int, int> dict = new Dictionary<int, int>();

    //create key (integer in list) if it doesn't exist yet, set value to 1
    //if it exists, increase value by 1
    foreach (int elem in a)
    {
        if (dict.ContainsKey(elem))
        {
            dict[elem]++;
        }
        else
        {
            dict.Add(elem, 1);
        }
    }

    //loop through dictionary and find value 1, set the value of that key to result
    foreach (var dictElem in dict)
    {
        if (dictElem.Value == 1)
        {
            result = dictElem.Key;
        }
    }
    return result;
}

//test list
List<int> a = new()
{
    1,
    2,
    3,
    2,
    1
};

Console.WriteLine(lonelyinteger(a));