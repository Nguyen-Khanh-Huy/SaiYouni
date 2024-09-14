using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    int BienKieuSoNguyen;
    //variables 2
    float BienKieuSoThuc;
    //variables 3 
    string BienKieuChuoi;
    //variables 4 
    bool BienKieuTrueFalse;
    //variables 5 
    char BienKieuKyTu;

    // 5 Enemies methods

    //Method 1
    public static double TheTich(double cao = 1, double dai = 1, double rong = 1)
    {
        return cao * dai * rong;
    }
    //Method 2
    public static string FullName(string ho, string ten, string tendem = "")
    {
        return ho + (tendem != "" ? " " + tendem : "") + " " + ten;
    }
    //Method 3
    public static int SoMax(int num1, int num2)
    {
        int max = (num1 > num2) ? num1 : num2;
        return max;
    }
    //Method 4
    public static void XinChao()
    {
        Console.WriteLine("Xin chào Unity C#");
    }
    //Method 5
    public class MyClass : MonoBehaviour
    {
        private int count = 0;
        private void Start()
        { 
            count = 100;
        }
        public int GetCount()
        { 
            return count;
        }
    }
}
