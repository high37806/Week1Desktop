using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdvanced6 : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private void Awake()
    {
        goblin = new Player6();
        slime = new Player7();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector3(4, 5, 6));


    }
    /*
    public void Method(IMovingEntity entity) ���� �����߻�
    {
        
    }*/
}
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}

public class Player6 : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}

public class Player7 : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �� �̵�");
    }
}

