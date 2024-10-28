static void Main(string[] args)
{
    /*
    int x = 9;
    int y = 10;
    int res = x + y;
    Print("Hello");

    Print(res.ToString());*/
    int[] arr = { 1, -1, 2, 4 };
    int x = GetIndex(arr, -1);
    Console.WriteLine(x.ToString());
}
public static void Print(string str)
{
    Console.WriteLine(str);
}

public static int GetIndex(int[] arr, int num)
{
    return GetIndex(arr, arr.Length, num);
}
public static int GetIndex(int[]arr, int length, int num)
{
    if (length == 1)
    {
        if (arr[0] == num)
            return 0;
        return -1;
    }
    if (arr[length - 1] == num)
        return length - 1;

    return GetIndex(arr, length - 1, num);
}
