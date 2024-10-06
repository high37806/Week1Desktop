using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property1 : MonoBehaviour
{
    private void Awake()
    {
        Player8 player = new Player8();
        player.CurrentHP = 100;
        Debug.Log(player.CurrentHP);
        player.CurrentHP = -100;
        Debug.Log(player.CurrentHP);
    }
}

public class Player8
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set
        {
            if(value >0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }
}
