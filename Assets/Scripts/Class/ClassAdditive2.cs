using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive2 : MonoBehaviour
{
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "����ȯ";
        player02.currentHP = 100;

        Debug.Log($"{player01.ID}�� ����ü��{player01.currentHP}");
        Debug.Log($"{player02.ID}�� ����ü��{player02.currentHP}");
    }
}

public struct Stats
{
    public string ID;
    public int currentHP;
}
