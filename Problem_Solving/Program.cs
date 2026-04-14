using Problem_Solving.Problems.Arrays;

namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [3, 2, 2, 5, 3];
            RemoveElement removeElement = new RemoveElement();

            int newarr = removeElement.RemoveElementFunction(arr, 3);

            Console.WriteLine(newarr);
        }
    }
}
