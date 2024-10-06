using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class method3 : MonoBehaviour
{
    private void Awake()
    {
        int a = 3, b = 4;
        Add(a,b);
    }

    public void Add(int num1,int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1}+{num2}={result}");
    }
}
