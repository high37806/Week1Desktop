using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive6 : MonoBehaviour
{
    private void Awake()
    {
        string str = "�ȳ��ϼ���";
        str.PrintData();
    }
}

public static class StringExtension
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}
