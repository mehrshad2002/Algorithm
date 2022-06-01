namespace AlgoApp
{
    public class InsetionSortC
    {
        public void InsertionSortF()
        {
            int[] arr = { 1, -23, 23, 0, 7, 222, 78 };
            InsertionSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
        public  void InsertionSort(int[] Arr)
        {
             for (var next = 1; next < Arr.Length; next++)
             {
                    var insert = Arr[next];
                    var moveItem = next;

                    while (moveItem > 0 && Arr[moveItem - 1] > insert)
                    {
                        Arr[moveItem] = Arr[moveItem - 1];
                        moveItem--;
                    }

                    Arr[moveItem] = insert;
                }
        }
    }
}
 
