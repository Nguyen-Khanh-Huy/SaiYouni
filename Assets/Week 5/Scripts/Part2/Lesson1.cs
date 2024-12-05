using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1<T>
{
    private T data;

    public void SetData(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Debug.Log("Data: " + data);
    }

    public static void CreateAndPrintData(T data)
    {
        Lesson1<T> newObj = new Lesson1<T>();
        newObj.SetData(data);
        newObj.PrintData();
    }
}
