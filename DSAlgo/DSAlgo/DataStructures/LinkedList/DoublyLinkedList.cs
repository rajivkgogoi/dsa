namespace DSAlgo.DataStructures.LinkedList.DLL
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node<T> prev;
    }

    public class DoublyLinkedList<T>
    {
        Node<T> head;
        Node<T> tail;

        public void AddToLast(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;

            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
        }

        public void AddToFirst(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;

            if(head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void ReadAllNodes()
        {
            var current = head;

            while(current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
