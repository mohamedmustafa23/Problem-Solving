using Problem_Solving.Problems.Arrays;

namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            //#27 Remove Element
            //int[] arr = [ 3, 2, 2, 4, 5];
            //RemoveElement removeElement = new RemoveElement();

            //int result = removeElement.RemoveElementFunction(arr, 2);

            //Console.WriteLine(newarr);

            //#26 Remove Duplicates from Sorted Array
            int[] arr = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int result = RemoveDuplicates.RemoveDuplicateFunction(arr);
            Console.WriteLine(result);

        }
    }
}
