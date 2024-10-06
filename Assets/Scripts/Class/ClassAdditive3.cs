using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive3 : MonoBehaviour
{
    private void Awake()
    {
        var a = ("조시환", 20);
        Debug.Log($"{a.Item1}의 나이 {a.Item2}");
        var (name, age) = a;
        Debug.Log($"{name}의 나이 {age}");
    }
}
