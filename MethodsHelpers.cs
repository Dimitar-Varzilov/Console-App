internal static class MethodsHelpers
{

    public static int Position(bool[] array)
    {
        int pos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == true)
            {
                pos = i + 1;
                break;
            }
        }
        return pos;
    }
}