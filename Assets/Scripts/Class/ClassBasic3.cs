using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassBasic3 : MonoBehaviour
{
    private Player3 player01;
    private Player3 player02;
    private Player3 player03;
    private void Awake()
    {
        player01 = new Player3("조시환");
        player02 = player01;
        player03 = player01.DeepCopy();
        player02.ID = "유니티";
        player03.ID = "언리얼";
        Debug.Log($"{player01.ID} {player02.ID} {player03.ID}");
    }
}

public class Player3
{
    public string ID;
    public Player3()
    {

    }
    public Player3(string id) : this()
    {
        ID = id;
    }

    public Player3 DeepCopy()
    {
        Player3 clone = new Player3();
        clone.ID = ID;
        return clone;
    }
}