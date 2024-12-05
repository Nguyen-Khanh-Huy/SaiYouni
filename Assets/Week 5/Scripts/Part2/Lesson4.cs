using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4<T>
{
    private List<T> items;

    public Lesson4()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
        Debug.Log($"Item added: {item}");
    }

    public bool RemoveItem(T item)
    {
        bool isRemoved = items.Remove(item);
        if (isRemoved)
        {
            Debug.Log($"Item removed: {item}");
        }
        else
        {
            Debug.Log($"Item not found: {item}");
        }
        return isRemoved;
    }

    public void PrintItems()
    {
        Debug.Log("Items in the list:");
        foreach (var item in items)
        {
            Debug.Log(item);
        }
    }
}
