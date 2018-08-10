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
    }
}
