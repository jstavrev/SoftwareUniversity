using System;

public class ArrayList<T>
{
    private const int startingCapacity = 2;
    private int capacity = 2;
    private int count = 0;
    private T[] items;

    public ArrayList()
    {
        this.items = new T[startingCapacity];
    }

    public int Count
    {
        get { return this.count; }
        set { count = value; }
    }

    public T this[int index]
    {
        get
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.items[index];
        }
        set
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == capacity)
        {
            T[] temporaryItems = new T[capacity * 2];
            Array.Copy(this.items, temporaryItems, this.Count);
            capacity *= 2;
            this.items = temporaryItems;
        }
        this.items[this.Count] = item;
        this.Count++;
    }

    public T RemoveAt(int index)
    {
        if (index <= this.Count && index >= 0)
        {
            T value = this.items[index];
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = items[i + 1];
            }
            this.items[this.Count - 1] = default(T);
            this.Count--;
            return value;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
