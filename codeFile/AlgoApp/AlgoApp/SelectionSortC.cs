namespace AlgoApp
{
    public class SelectionSortC
    {
        public void SelectionSortF()
        {
            int[] arr = { 1, 2, 23, 43, 200, -23 };
            SelectionSort(arr); 

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public void SelectionSort(int[] Arr)
        {
            for (var i = 0; i < Arr.Length; i++)
            {
                var smallest = i;
                // for find smallest elements !
                for (var index = i + 1; index < Arr.Length; index++)
                {
                    if (Arr[smallest] > Arr[index])
                    {
                        smallest = index;
                    }
                }
                Swap(ref Arr[i], ref Arr[smallest]);//smalest --> Index of smalest Elements
            }
        }

        private static void Swap(ref int first, ref int secend)
        {
            var temp = first;
            first = secend;
            secend = temp;
        }
    }
}
 
