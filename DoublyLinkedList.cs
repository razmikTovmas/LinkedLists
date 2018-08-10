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

        public bool Remove(int value)
        {
            if (head == null) return false;

            if (value == head.Value)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                    head.Previous = null;
                }

                return true;
            }

            Node temp = head.Next;

            while (temp != null && value != temp.Value)
            {
                temp = temp.Next;
            }

            if (temp == tail)
            {
                tail = tail.Previous;
                tail.Next = null;

                return true;
            }
            else if (temp != null)
            {
                temp.Previous.Next = temp.Next;
                temp.Next.Previous = temp.Previous;

                return true;
            }

            return false;
        }

        public void Traverse()
        {
            Node temp = head;

            while (temp.Next != null)
            {
                System.Console.Write(temp.Value + " -> ");
                temp = temp.Next;
            }

            System.Console.WriteLine(temp.Value);
        }

        public void ReverseTraversal()
        {
            Node temp = tail;

            while (temp.Previous != null)
            {
                System.Console.Write(temp.Value + " <- ");
                temp = temp.Previous;
            }

            System.Console.WriteLine(temp.Value);
        }
    }
}
