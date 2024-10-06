using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassBasic1 : MonoBehaviour
{


    private void Awake()
    {
        Player player1 = new Player();
        Enemy enemy1 = new Enemy();
        player1.TakeDamage(100);
        player1.RecoveryHP(100);
        enemy1.AtteckToTarget(player1);
    }


}
public  class Enemy
{
    private  Player player;

    public  void AtteckToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}

public  class Player
{
    private string ID = "����ȯ";
    private int currentHP = 1000;
    public  void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"����HP:{currentHP}");
        }
    }

    public void RecoveryHP(int HP)
    {
        currentHP += HP;
        Debug.Log($"����HP:{currentHP}");
    }
}
