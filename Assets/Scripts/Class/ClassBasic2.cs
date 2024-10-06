using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassBasic2 : MonoBehaviour
{
    public Player2 player01,player02;
    private void Awake()
    {
        player01 = new Player2();
        player02 = new Player2("����ȯ",10);
        Debug.Log($"{player01.currentHP},{player02.currentHP}");
    }
}

public class Player2
{
    public string ID;
    public int currentHP;

    public Player2()
    {
        ID = "����ȯ";
        currentHP = 1000;
    }
    public Player2(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}
