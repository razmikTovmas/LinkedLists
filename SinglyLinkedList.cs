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

        public void Add(int value) { }
        public bool Contains(int value) { return false; }
        public bool Remove(int value) { return false; }
        public void Traverse() { }
        public void ReverseTraversal() { }

    }
}
