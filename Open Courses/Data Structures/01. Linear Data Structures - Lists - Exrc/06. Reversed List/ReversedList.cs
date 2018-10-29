//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class ReversedList<T> : IEnumerable
//{
//    private T[] array;
//    private const int startingCapacity = 2;
//    private int count;
//    private int capacity;
//    private int currentPosition = startingCapacity - 1;

//    public ReversedList(int capacity = startingCapacity)
//    {
//        this.array = new T[capacity];
//        this.Capacity = capacity;
//    }

//    public int Capacity
//    {
//        get { return capacity; }
//        set { capacity = value; }
//    }

//    public T this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= this.Count)
//            {
//                throw new IndexOutOfRangeException();
//            }
//            return array[index];
//        }

//        set
//        {
//            if (index < 0 || index >= this.Count)
//            {
//                throw new IndexOutOfRangeException();
//            }
//            array[index] = value;
//        }
//    }

//    public int Count
//    {
//        get { return count; }
//        set { count = value; }
//    }

//    public void Add(T item)
//    {
//        if (this.Count == this.array.Length)
//        {
//            Grow();
//        }
//        array[currentPosition] = item;
//        currentPosition--;
//        this.Count++;
//    }

//    public T RemoveAt(int index)
//    {
//        if (this.Count == 0)
//        {
//            throw new InvalidOperationException();
//        }
//        T element = this.array[index];

//        for (int i = index; i < array.Length - 1; i++)
//        {
//            array[i] = array[i + 1];
//        }
//        this.Count--;
//        this.array[array.Length - 1] = default(T);
//        return element;
//    }

//    public void Grow()
//    {
//        T[] tempArr = new T[this.array.Length * 2];
//        CopyArray(tempArr);
//        this.array = tempArr;
//        this.Capacity = this.array.Length;
//    }

//    public void CopyArray(T[] tempArr)
//    {
//        int position = 0;

//        for (int i = array.Length - 1; i >= 0; i--)
//        {
//            tempArr[tempArr.Length - (1 + position)] = array[array.Length - (1 + position)];
//            position++;
//        }

//        currentPosition = tempArr.Length - (position + 1);
//    }

//    public IEnumerator<T> GetEnumerator()
//    {
//        foreach (var item in this.array)
//        {
//            yield return item;
//        }
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return this.GetEnumerator();
//    }
//}

using System;
using System.Collections;
using System.Collections.Generic;

public class ReversedList<T> : IEnumerable<T>
{
    private const int InitialCapacity = 2;

    private T[] data;

    public ReversedList(int capacity = InitialCapacity)
    {
        this.data = new T[capacity];
    }

    public int Count { get; private set; }

    public int Capacity => this.data.Length;

    public T this[int index]
    {
        get
        {
            this.ValidateIndex(index);
            return this.data[this.Count - index - 1];
        }

        set
        {
            this.ValidateIndex(index);
            this.data[this.Count - index - 1] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.data.Length)
        {
            this.Resize();
        }

        this.data[Count] = item;
        this.Count++;
    }

    public T RemoveAt(int index)
    {
        this.ValidateIndex(index);
        var removedItem = this.data[this.Count - index - 1];

        for (int i = this.Count - index; i < this.Count; i++)
        {
            this.data[i - 1] = this.data[i];
        }

        this.Count--;
        return removedItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count - 1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private void Resize()
    {
        Array.Resize(ref this.data, this.Count * 2);
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }
    }
}


