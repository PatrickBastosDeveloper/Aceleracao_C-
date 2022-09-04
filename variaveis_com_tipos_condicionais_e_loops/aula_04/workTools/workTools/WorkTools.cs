namespace WorkTools;
public static class  Main
{
    public static int CountOf(int[] numbers, int value)
    {     
        var count = 0;

        foreach(var number in numbers)   
        {
            if(number == value) count++;
        }

        return count;
    }
}