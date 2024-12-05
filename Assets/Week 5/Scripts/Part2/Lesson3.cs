using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3<T>
{
    public static void Swap(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
