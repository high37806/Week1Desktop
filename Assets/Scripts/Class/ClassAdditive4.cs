using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAdditive4 : MonoBehaviour
{
    private void Awake()
    {
        Enemy3 enemy01 = new Enemy3();
        enemy01.numeric = 0;
        Enemy3 enemy02 = new Enemy3();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        Enemy3.species = "°íºí¸°";
        Debug.Log(Enemy3.species);
    }
}

public class Enemy3
{
    public int numeric;

    public static string species;
}
