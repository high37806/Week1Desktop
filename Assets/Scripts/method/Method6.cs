using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method6 : MonoBehaviour
{
    private void Awake()
    {
        Add(10, 20);
        Add(172.3f, 89.5f);
    }

    public void Add(int num1,  int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1}+{num2}={result}");
    }

    public void Add(float num1, float num2)
    {
        float result = num1 + num2;
        Debug.Log($"{num1}+{num2}={result}");
    }
}
