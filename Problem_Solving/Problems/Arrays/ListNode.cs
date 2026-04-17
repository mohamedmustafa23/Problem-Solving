namespace Problem_Solving.Problems.Arrays
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode BuildList(int[] values)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }
        public static void PrintList(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }

            Console.WriteLine();
        }
    }

}
