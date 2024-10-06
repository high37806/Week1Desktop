using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method8 : MonoBehaviour
{
    private void Awake()
    {
        Player("조시환");
        Player("조시환", 3000);
    }

    public void Player(string ID, int health = 1000)
    {
        Debug.Log($"ID:{ID}, Health:{health}");
    }
}
