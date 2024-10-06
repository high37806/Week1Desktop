using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClassAdvanced4 : MonoBehaviour
{
    Parent parent = new Child1();
    private void Awake()
    {
        if(parent is Child1)
        {
            Debug.Log("yes");
        }
        Child2 child = parent as Child2;
        if(child == null)
        {
            Debug.Log("eyes");
        }
    }

}

public class Parent
{

}

public class Child1 : Parent
{

}

public class Child2 : Parent
{

}
