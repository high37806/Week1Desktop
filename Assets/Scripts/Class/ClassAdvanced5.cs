using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced5 : MonoBehaviour
{
    private Entity2 goblin;
    private Entity2 slime;

    private void Awake()
    {
        goblin = new Goblin2(5, 100);
        slime = new Slime2(10, 50);

        goblin.Attack(slime);
        slime.Attack(goblin);
    }
}

public abstract class Entity2
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity2 target);
    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage} 감소");
        }
        else
        {
            Debug.Log("갔어....");
        }
    }


}
public class Goblin2 : Entity2
{
    public Goblin2(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity2 target)
    {
        Debug.Log("고블린의 ㅇㄱㄴㄷㅅ");
        target.TakeDamage(damage);
    }
}
public class Slime2 : Entity2
{
    public Slime2(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity2 target)
    {
        Debug.Log("슬라임의 ㅇㄱㄴㄷㅅ");
        target.TakeDamage(damage);
    }
}
