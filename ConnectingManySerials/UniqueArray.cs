using System;

public class UniqueArray<T> where T : IEquatable<T>
{
    private T[] _array;
    private int _count;

    public UniqueArray(int size)
    {
        _array = new T[size];
        _count = 0;
    }

    public bool Add(T item)
    {
        // Check if item already exists
        for (int i = 0; i < _count; i++)
        {
            if (_array[i].Equals(item))
            {
                return false; // Item already exists, not added
            }
        }

        // Add item to the array
        if (_count < _array.Length)
        {
            _array[_count] = item;
            _count++;
            return true; // Item added successfully
        }
        else
        {
            return false; // Array is full, cannot add
        }
    }

    public int getSize()
    {
        return _count;
    }
    public T GetElement(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }
        return _array[index];
    }
    public void Clear()
    {
        _count = 0; // Reset count, effectively clearing the array
        // You could also optionally set elements to default(T), but not strictly necessary
    }
    public bool RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            return false; // Index out of range
        }

        // Shift elements to fill the gap
        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
        return true;
    }

}