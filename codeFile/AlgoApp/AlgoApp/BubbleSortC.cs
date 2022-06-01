namespace AlgoApp
{
    public class BubbleSortC
    {
        public void BubbleSortF()
        {
            int[] Arr = { 2, 3, 1, 23, 100, -23, -100 };

            // sorting !
            for( int i = 0; i < Arr.Length; i++)
            {
                for( int j = i + 1; j < Arr.Length; j++)
                {
                    if( Arr[i] > Arr[j])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[i];
                        Arr[i] = temp;
                    }
                }
            }

            for( int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i] + " ");
            }
        }
    }
}
 
