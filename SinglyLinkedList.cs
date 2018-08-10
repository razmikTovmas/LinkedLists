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

        public bool Remove(int value) { return false; }
        public void Traverse() { }
        public void ReverseTraversal() { }

    }
}
