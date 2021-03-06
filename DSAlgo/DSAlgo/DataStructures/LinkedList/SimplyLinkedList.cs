namespace DSAlgo.DataStructures.LinkedList
{
    internal class Node<T>
    {
        public T data;
        public Node<T> next;
    }

    internal class SimplyLinkedList<T>
    {
        private Node<T> head = null;
        private Node<T> tail = null;

        public void AddToLast(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;

            if(head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = tail.next;
            }
        }

        public void AddToFirst(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

        }

        public void ReadAllNodes()
        {
            Node<T> current = head;
            if(current == null)
            {
                Console.WriteLine("LinkedList is empty.");
                return;
            }
            
            while(current.next != null)
            {
                Console.WriteLine(current.data);

                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
