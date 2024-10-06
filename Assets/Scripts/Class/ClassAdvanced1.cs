using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced1 : MonoBehaviour
{
    private void Awake()
    {
        Player4 player  = new Player4();

        player.SetCurrentHP(100);
        Debug.Log($"HP:{player.GetCurrentHP()}");
    }
}

public class Player4
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }
    public int GetCurrentHP()
    {
        return currentHP;
    }
}
