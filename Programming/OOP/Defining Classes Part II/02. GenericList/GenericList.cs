using System;
using System.Linq;

public class GenericList<T> where T : IComparable
{
    private const int DefaultCapacity = 25;

    private T[] elements;

    private int currentLength = 0;

    public GenericList(int capacity)
    {
        elements = new T[capacity];
    }

    public GenericList()
        : this(DefaultCapacity)
    {
    }

    public T this[int index]
    {
        get
        {
            if (index >= currentLength || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            return elements[index];
        }
        set
        {
            if (index >= currentLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            elements[index] = value;
        }
    }

    public void Add(T element)
    {
        var capacity = this.elements.Length;

        //MaxCapacity multiplied by 2
        if (currentLength >= capacity)
        {
            Array.Resize(ref elements, capacity * 2);
        }
        
        this.elements[currentLength] = element;
        currentLength++;
    }

    public T GetMax()
    {
        var max = elements.Max();
        return max;
    }

    public T GetMin()
    {
        var min = elements.Min();
        return min;
    }

    public int GetLength()
    {
        return currentLength;
    }

    public void Clear()
    {
        Array.Clear(this.elements, 0, this.GetLength());
        currentLength = 0;
        Console.WriteLine("Array is cleared");
    }

    public int FindIndexByValue(T value)
    {
        int found = -1;

        for (int i = 0; i < this.GetLength(); i++)
        {
            if (this.elements[i].Equals(value))
            {
                found = i;
                break;
            }
        }

        return found;
    }

    public void Remove(int index)
    {
        if (index < currentLength && index >= 0)
        {
            T[] temp = new T[elements.Count() - 1];
            int counter = 0;
            for (int i = 0; i < elements.Count(); i++)
            {
                if (counter == index)
                {
                    i++;
                }
                temp[counter] = elements[i];
                counter++;
            }
            currentLength--;
            elements = temp;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    public void Insert(int index, T element)
    {
        if (index <= currentLength && index >= 0)
        {
            T[] temp = new T[elements.Count() + 1];
            int counter = 0;
            for (int i = 0; i < temp.Count(); i++)
            {
                if (i == index)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = elements[counter];
                    counter++;
                }
            }
            currentLength++;
            elements = temp;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    public override string ToString()
    {
        return string.Join(",", elements.Take(currentLength));
    }
}
