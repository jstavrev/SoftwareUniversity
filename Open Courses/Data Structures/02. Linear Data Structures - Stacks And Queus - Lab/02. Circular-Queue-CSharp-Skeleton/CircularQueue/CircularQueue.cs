using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;
    private T[] arr;
    private int startIndex = 0;
    private int endIndex = 0;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        arr = new T[capacity];
        this.Count = 0;
    }

    public void Enqueue(T element)
    {
        if (this.Count == arr.Length)
        {
            Resize();
        }

        arr[endIndex] = element;
        endIndex++;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArr = new T[arr.Length * 2];
        CopyAllElements(newArr);
    }

    private void CopyAllElements(T[] newArray)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            newArray[i] = arr[i];
        }
    }

    // Should throw InvalidOperationException if the queue is empty
    public T Dequeue()
    {
        T element = arr[startIndex];
        arr[startIndex] = default(T);
        startIndex++;

        return element;
    }

    public T[] ToArray()
    {
        // TODO
        throw new NotImplementedException();
    }
}


public class Example
{
    public static void Main()
    {

        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        int first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
