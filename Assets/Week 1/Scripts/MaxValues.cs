using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int: 2,147,483,647
        int maxInt = 0;
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float: 3.40282347E+38
        float maxFloat = 0;
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double: 1.79769313486232E+308
        double maxDouble = 0;
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }

}
