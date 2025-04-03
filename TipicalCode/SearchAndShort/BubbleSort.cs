namespace SearchAndSort
{
    public class BubbleSort
    {
        static public int[] BubbleSortV1(int[] NumArray)
        {
            try
            {
                var n = NumArray.Length;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (NumArray[j] > NumArray[j + 1])
                        {
                            var tempVar = NumArray[j];
                            NumArray[j] = NumArray[j + 1];
                            NumArray[j + 1] = tempVar;
                        }
                return NumArray;
            }
            catch (Exception ex)
            {
                return new int[0];
            }
        }
    }
}
