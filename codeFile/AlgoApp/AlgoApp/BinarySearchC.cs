namespace AlgoApp
{
    public class BinarySearchC
    {
        public void BinarySearchF()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int x = 4;
            int n = arr.Length;
            int result = BinarySearch(arr, 0, n - 1, x);

            if (result == -1)
            {
                Console.WriteLine("Not Find !");
            }
            else
            {
                Console.WriteLine($"Yes we found it att index {result}");
            }
        }

        public static int BinarySearch(int[] a, int k, int b, int x)
        {
            int mid = (k + b) / 2;

            if (b >= k)
            {
                if (a[mid] == x)
                {
                    return mid;
                }
                else if (a[mid] > x)
                {
                    return BinarySearch(a, k, b - 1, x);
                }
                else
                {
                    return BinarySearch(a, k + 1, b, x);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
 
