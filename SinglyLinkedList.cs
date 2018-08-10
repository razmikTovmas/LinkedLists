namespace LinkedLists
{
    class SinglyLinkedList
    {
        private class Node
        {
            private int value;
            private Node next;

            public Node(int value)
            {
                Value = value;
            }

            public int Value { get => value; set => this.value = value; }
            public Node Next { get => next; set => next = value; }
        }

        private Node head;
        private Node tail;

        public void Add(int value)
        {
            Node temp = new Node(value);

            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                tail.Next = temp;
                tail = temp;
            }
        }

        public bool Contains(int value)
        {
            Node temp = head;

            while (temp != null && temp.Value != value)
            {
                temp = temp.Next;
            }

            return temp != null;
        }

        public bool Remove(int value)
        {
            if (head != null) return false;

            Node temp = head;

            if (temp.Value == value)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }
            }

            while (temp.Next != null && temp.Next.Value != value)
            {
                temp = temp.Next;
            }

            if (temp.Next != null)
            {
                if (temp.Next == tail)
                {
                    tail = temp;
                }
                else
                {
                    temp.Next = temp.Next.Next;
                    return true;
                }
            }

            return false;
        }

        public void Traverse() { }
        public void ReverseTraversal() { }

    }
}
