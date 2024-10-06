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
            Debug.Log($"ü���� {damage} ����");
        }
        else
        {
            Debug.Log("����....");
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
        Debug.Log("����� ����������");
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
        Debug.Log("�������� ����������");
        target.TakeDamage(damage);
    }
}
