using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced2 : MonoBehaviour
{
    private void Awake()
    {
        Player5 player = new Player5("¡∂Ω√»Ø", 100);
        Debug.Log($"{player.ID},{player.currentHP}");
    }
}

public class Entity
{
    public string ID;
    public int currentHP;
}

public class Player5 : Entity
{
   new public string ID;

    public Player5(string id, int hp)
    {
        base.ID = "Noname";
        ID = id;
        currentHP = hp;
    }
}