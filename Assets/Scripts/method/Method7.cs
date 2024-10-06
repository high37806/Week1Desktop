using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method7 : MonoBehaviour
{
    private void Awake()
    {
        Sum(1, 2);
        Sum(1,2,3);
        Sum(1,2,3,4);
    }
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Debug.Log($"гу╟Х:{sum}");
    }
}
