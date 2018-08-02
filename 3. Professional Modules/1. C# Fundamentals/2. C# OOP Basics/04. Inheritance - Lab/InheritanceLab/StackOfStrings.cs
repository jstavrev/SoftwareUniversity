using System;
using System.Collections.Generic;
using System.Text;


public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        this.Data = new List<string>();
    }

    public List<string> Data
    {
        get { return new List<string>(data); }
        set { data = value; }
    }

    public void Push(string item)
    {
        Data.Add(item);
    }

    public string Pop()
    {
        string result = "";
        if (!IsEmpty())
        {
            var lastIndex = data.Count - 1;
            result = data[lastIndex];
            data.RemoveAt(lastIndex);
        }
        return result;
    }

    public string Peek()
    {
        string result = "";
        if (!IsEmpty())
        {
            return data[data.Count - 1];
        }
        return result;
    }

    public bool IsEmpty()
    {
        if (this.Data.Count == 0)
        {
            return true;
        }
        return false;
    }
}

