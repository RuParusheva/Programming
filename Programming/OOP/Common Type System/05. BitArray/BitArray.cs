using System;
using System.Collections;
using System.Collections.Generic;

public class BitArray : IEnumerable<int>
{
    private const int Capacity = 64;

    private ulong item;

    public int this[int index]
    {
        get
        {
            if (!(0 <= index && index < Capacity))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return (int)((this.item >> index) & 1);
        }
        set
        {
            if (!(0 <= index && index < Capacity))
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (value == 0)
            {
                var mask = 1UL << index;
                this.item = this.item & (~mask);
            }
            else if (value == 1)
            {
                var mask = 1UL << index;
                this.item = this.item | mask;
            }
            else
            {
                throw new ArgumentException("BitArray accepts only 0 or 1!");
            }
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = Capacity - 1; i >= 0; i--)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public static bool operator ==(BitArray array1, BitArray array2)
    {
        return Equals(array1, array2);
    }

    public static bool operator !=(BitArray array1, BitArray array2)
    {
        return !(array1 == array2);
    }

    public override bool Equals(object obj)
    {
        var other = obj as BitArray;

        if (other == null)
        {
            return false;
        }

        return this.item == other.item;
    }

    public override int GetHashCode()
    {
        return this.item.GetHashCode();
    }

    public override string ToString()
    {
        return string.Concat(this);
    }
}