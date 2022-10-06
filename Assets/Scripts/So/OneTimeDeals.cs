using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OneTimeDealsSO", menuName = "ScrictableObjects/OneTimeDeals")]
public class OneTimeDeals : ScriptableObject
{
    public string[] stateString;
    public bool[] stateBool;
    public int[] stateInt;

    public void SetString(int index, string state)
    {
        stateString[index] = state;
    }
    public void SetBool(int index, bool state)
    {
        stateBool[index] = state;
    }
    public void SetInt(int index, int state)
    {
        stateInt[index] = state;
    }
}
