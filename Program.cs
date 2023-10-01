namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arras = new int[] { 1, 2, 3 };
            SortArray(arras, out int[] sorteddesc, out int[] sortedasc);
            foreach (int i in sorteddesc)
            {
                Console.Write(i + " ");
            }
            foreach (int i in sortedasc)
            {
                Console.Write(i + " ");
            }
        }

        public static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);
        }

        public static int[] SortArrayDesc(int[] array)
        {
            int Temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        Temp = array[i];
                        array[i] = array[j];
                        array[j] = Temp;
                    }
                }
            }
            return array;
        }

        public static int[] SortArrayAsc(int[] array)
        {
            int Temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Temp = array[j];
                        array[j] = array[i];
                        array[i] = Temp;
                    }
                }
            }
            return array;
        }
    }
}