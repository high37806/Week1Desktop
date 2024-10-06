using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive5 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Calculator.Sum(20, 55));
        Debug.Log(Calculator.num);
    }
}

public static class Calculator
{
    public static int num;

    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
