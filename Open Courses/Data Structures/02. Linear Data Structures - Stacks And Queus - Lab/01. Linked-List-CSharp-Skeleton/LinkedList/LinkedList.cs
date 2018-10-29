using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    public LinkedList()
    {
        this.Head = null;
        this.Tail = null;
    }

    public void AddFirst(T item)
    {
        Node newNode = new Node(item);

        if (Count == 0)
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            newNode.Next = this.Head;
            this.Head = newNode;
        }
        Count++;
    }

    public void AddLast(T item)
    {
        Node newNode = new Node(item);

        if (Count == 0)
        {
            this.Head = newNode;
            this.Tail = newNode;
        }
        else
        {
            this.Tail.Next = newNode;
            this.Tail = newNode;
        }
        Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        T element = this.Head.Value;
        this.Head = this.Head.Next;
        Count--;
        return element;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.Tail.Value;

        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            Node node = this.Head;
            while (true)
            {
                if (node.Next.Next == null)
                {
                    node.Next = null;
                    this.Tail = node;
                    break;
                }
                node = node.Next;
            }
        }
        Count--;
        return element;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.Head;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}

