namespace LinkedLists
{
    class DoublyLinkedList
    {
        private class Node
        {
            private int value;
            private Node next;
            private Node previous;

            public Node(int value)
            {
                Value = value;
            }

            public int Value { get => value; set => this.value = value; }
            public Node Next { get => next; set => next = value; }
            public Node Previous { get => previous; set => previous = value; }
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
                temp.Previous = tail;
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
