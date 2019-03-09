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
                    if (array[position] > array[position + 1])
                    {
                        ExchangeNeighborElements(array, position);
                    }
                }
            }
        }

        public static void ShakerSort(this int[] array)
        {
            var iterationCount = array.Length / 2;
            for (var iteration = 0; iteration < iterationCount; iteration++)
            {
                int boundaryPosition = array.Length - iteration - 1;
                for (var position = iteration; position < boundaryPosition; position++)
                {
                    if (array[position] > array[position + 1])
                    {
                        ExchangeNeighborElements(array, position);
                    }
                }

                for (var position = boundaryPosition ; position > iteration; position--)
                {
                    if (array[position] < array[position - 1])
                    {
                        ExchangeNeighborElements(array, position - 1);
                    }
                }
            }
        }

        private static void ExchangeNeighborElements(int[] array, int startPosition)
        {
            var temp = array[startPosition];
            array[startPosition] = array[startPosition + 1];
            array[startPosition + 1] = temp;
        }
    }
}
