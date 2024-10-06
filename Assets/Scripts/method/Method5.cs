using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method5 : MonoBehaviour
{
    private void Awake()
    {
        int a = 5, b = 4, result1 = 0, result2 = 0;
        Devide(a,b,out result1,out result2);
        Debug.Log($"¸ò = {result1}, ³ª¸ÓÁö = {result2}");
    }

    public void Devide(int num1, int num2, out int result1, out int result2)
    {
        result1 = num1 / num2;
        result2 = num1 % num2;
    }
}
