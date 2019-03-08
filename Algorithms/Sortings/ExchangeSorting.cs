namespace Sortings
{
    public static class ExchangeSorting
    {
        public static void BubbleSort(this int[] array)
        {
            var iterationCount = array.Length - 1;
            for (var iteration = 0; iteration < iterationCount; iteration++)
            {
                var lastPosition = iterationCount - iteration;
                for (var position = 0; position < lastPosition; position++)
                {
                    var firstСomparedElement = array[position];
                    var secondCompareElement = array[position + 1];
                    if (firstСomparedElement > secondCompareElement)
                    {
                        array[position] = secondCompareElement;
                        array[position + 1] = firstСomparedElement;
                    }
                }
            }
        }
    }
}
