using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving.Problems.ArraysAndLinkedList.Recursion
{
    public static class NumberOfOneBits
    {
        //Recursion - Divide and Conquer
        public static int HammingWeight(int n)
        {
            if(n == 0) return 0;

            int numOfOne = HammingWeight(n /  2);
            int bit = n % 2;
            if(bit == 1)
            {
                numOfOne++;
            }
            return numOfOne;
        }
    }
}
