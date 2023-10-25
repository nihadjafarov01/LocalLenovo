using System;

namespace Collection;

public class IntList
{
    int[] _array = new int[0];


    public void Add(int number)
    {
        Array.Resize(ref _array, _array.Length + 1);
        _array[_array.Length - 1] = number;
    }

    public void Add(params int[] numbers)
    {
        _array = _array.Concat(numbers).ToArray();
    }

    public int GetIndex(int index)
    {
        if (index >= 0 && index < _array.Length)
        {
            return _array[index];
        }
        else
        {
            return -1;
        }
    }

    public int[] GetAll()
    {
        return _array;
    }
    public void Print()
    {
            foreach (int item in _array)
    {
        Console.WriteLine(item);
    }
    }

    public void Sort()
    {
        int[] sortedArray = new int[_array.Length];
        Array.Copy(_array, sortedArray, _array.Length);
        Array.Sort(sortedArray);
    }


    public int Search(int value)
    {
        int indexOfValue = -1;
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] == value)
            {
                Console.WriteLine($"{_array[i]} beraberdir {value}");
                indexOfValue = i;
                break;
            }
            else
            {
                Console.WriteLine($"{_array[i]} beraber deyil {value}");
            }
        }
        return indexOfValue;
    }
}