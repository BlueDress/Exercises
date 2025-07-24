namespace Exercises.LinkedList
{
    public static class MiddleOfTheLinkedList
    {
        public static ListNode Solution(ListNode head)
        {
            var middle = head;
            var counter = head;

            while (true)
            {
                if (counter.Next == null)
                {
                    break;
                }

                if (counter.Next.Next == null)
                {
                    middle = middle.Next;
                    break;
                }

                counter = counter.Next.Next;
                middle = middle.Next;
            }

            return middle;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
