using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive1 : MonoBehaviour
{
    private void Awake()
    {
        Parent3 p = new Parent3();
        p.Method01();

        Child3 child = new Child3();
        child.Method01();

        Parent3 pc = new Child3();
        pc.Method01();
    }
}

public class Parent3
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child3 : Parent3
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}
