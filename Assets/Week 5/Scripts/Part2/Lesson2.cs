using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2<T> where T : IComparable<T>
{
    public static T GetMax(T[] array)
    {
        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
}
