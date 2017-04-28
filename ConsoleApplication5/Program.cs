using System;
using System.Linq;

namespace TheMaximumSubarray
{
    public class MaximumSubArrayDP
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[] { 10, 14, 52, -2, 10, -22, -40, -3, 11 };
            var xs =
                    from n in System.Linq.Enumerable.Range(0, arr.Length)
                    from l in System.Linq.Enumerable.Range(1, arr.Length - n)
                    let subseq = arr.Skip(n).Take(l)
                    orderby subseq.Count() descending
                    orderby subseq.Sum() descending
                    select subseq;
            var maxSumSubseq = xs.First().Sum();
            Console.WriteLine(maxSumSubseq);
            Console.ReadKey();
        }
    }
}
