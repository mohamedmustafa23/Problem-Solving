namespace Problem_Solving.Problems.Arrays
{
    public static class RemoveDuplicatesFromSortedList2
    {

        public static ListNode DeleteDuplicates(ListNode head)
        {

            ListNode dumy = new ListNode(0);
            dumy.next = head;

            ListNode prev = dumy;
            ListNode current = head;
            while (current != null)
            {
                bool duplicate = false;
                while (current.next != null && current.val == current.next.val )
                {
                    duplicate = true;
                    current = current.next;
                }

                if(duplicate)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = prev.next;
                }
                current = current.next;
            }
            return dumy;
        }
    }
}
