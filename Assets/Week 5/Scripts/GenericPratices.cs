using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPratices : MonoBehaviour
{
    public void Start()
    {
        //Ở bài tập này bạn hãy tạo nhiều class riêng biệt nha
        //Mối script một class nhé

        //BaiTap1();
        //BaiTap2();
        //BaiTap3();
        //BaiTap4();
        //BaiTap5();
    }

    public void BaiTap1()
    {
        Lesson1<int>.CreateAndPrintData(5);          // int
        Lesson1<float>.CreateAndPrintData(3.14f);    // float
        Lesson1<string>.CreateAndPrintData("Hello!"); // string
    }
    public void BaiTap2()
    {
        // int
        int[] intArray = { 1, 5, 3, 9, 2 };
        int maxInt = Lesson2<int>.GetMax(intArray);
        Debug.Log("Max Int: " + maxInt);

        // float
        float[] floatArray = { 3.5f, 2.1f, 7.9f, 6.2f };
        float maxFloat = Lesson2<float>.GetMax(floatArray);
        Debug.Log("Max Float: " + maxFloat);

        // string
        string[] stringArray = { "apple", "grapefruit", "banana" };
        string maxString = Lesson2<string>.GetMax(stringArray);
        Debug.Log("Max String: " + maxString);
    }
    public void BaiTap3()
    {
        // Swap int
        int a = 5, b = 10;
        Debug.Log($"Before Swap Int: a = {a}, b = {b}");
        Lesson3<int>.Swap(ref a, ref b);
        Debug.Log($"After Swap Int: a = {a}, b = {b}");

        // Swap float
        float x = 3.14f, y = 2.71f;
        Debug.Log($"Before Swap Float: x = {x}, y = {y}");
        Lesson3<float>.Swap(ref x, ref y);
        Debug.Log($"After Swap Float: x = {x}, y = {y}");

        // Swap string
        string str1 = "Hello", str2 = "World";
        Debug.Log($"Before Swap String: str1 = {str1}, str2 = {str2}");
        Lesson3<string>.Swap(ref str1, ref str2);
        Debug.Log($"After Swap String: str1 = {str1}, str2 = {str2}");
    }
    public void BaiTap4()
    {
        // int
        Lesson4<int> intList = new Lesson4<int>();
        intList.AddItem(10);
        intList.AddItem(20);
        intList.AddItem(30);

        intList.RemoveItem(20);
        intList.PrintItems();

        // float
        Lesson4<float> floatList = new Lesson4<float>();
        floatList.AddItem(3.14f);
        floatList.AddItem(2.71f);
        floatList.AddItem(1.41f);

        floatList.RemoveItem(2.71f);
        floatList.PrintItems();

        // string
        Lesson4<string> stringList = new Lesson4<string>();
        stringList.AddItem("Apple");
        stringList.AddItem("Banana");
        stringList.AddItem("Cherry");

        stringList.RemoveItem("Banana");
        stringList.PrintItems();
    }
    public void BaiTap5()
    {
        // int co ton tai
        int[] intArray = { 1, 2, 3, 4, 5 };
        int intToFind = 3;
        bool intExists = Lesson5<int>.ContainsInArray(intArray, intToFind);
        Debug.Log($"{intToFind} exists in intArray: {intExists}");

        // float co ton tai
        List<float> floatList = new List<float> { 3.14f, 2.71f, 1.41f };
        float floatToFind = 2.71f;
        bool floatExists = Lesson5<float>.ContainsInList(floatList, floatToFind);
        Debug.Log($"{floatToFind} exists in floatList: {floatExists}");

        // string co ton tai
        List<string> stringList = new List<string> { "apple", "banana", "cherry" };
        string stringToFind = "banana";
        bool stringExists = Lesson5<string>.ContainsInList(stringList, stringToFind);
        Debug.Log($"\"{stringToFind}\" exists in stringList: {stringExists}");

        // string khong ton tai
        bool nonExistent = Lesson5<string>.ContainsInList(stringList, "grape");
        Debug.Log($"\"grape\" exists in stringList: {nonExistent}");
    }
}
