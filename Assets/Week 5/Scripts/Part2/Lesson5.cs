using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5<T>
{
    // Kiem tra co ton hay hay khong
    public static bool ContainsInArray(T[] array, T element)
    {
        return Array.Exists(array, e => EqualityComparer<T>.Default.Equals(e, element));
    }

    // Phan tu co ton tai
    public static bool ContainsInList(List<T> list, T element)
    {
        return list.Contains(element);
    }
}
