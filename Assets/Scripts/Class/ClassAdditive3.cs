using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive3 : MonoBehaviour
{
    private void Awake()
    {
        var a = ("����ȯ", 20);
        Debug.Log($"{a.Item1}�� ���� {a.Item2}");
        var (name, age) = a;
        Debug.Log($"{name}�� ���� {age}");
    }
}
