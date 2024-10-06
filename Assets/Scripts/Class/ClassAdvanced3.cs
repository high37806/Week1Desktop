using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced3 : MonoBehaviour
{
    private void Awake()
    {
        Enemy2 slime = new Slime();
        Enemy2 goblin = new Goblin();
        slime.Attack();
        goblin.Attack();
    }
}

public class Enemy2
{
    public virtual void Attack()
    {
        Debug.Log("�� ����");
    }
}

public class Slime : Enemy2
{
    public override void Attack()
    {
        Debug.Log("������ ����");
    }
}

public class Goblin : Enemy2
{
    public override void Attack()
    {
        Debug.Log("��� ����");
    }
}
