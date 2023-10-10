using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Stats", fileName = "New")]
public class WriteStats : ScriptableObject
{
    [Tooltip("Количество убитых")]
    [SerializeField] private int killFull;
    public int KillFull
    {
        get { return killFull; }
        set { killFull = killFull + value; }

    }

    [Tooltip("Количество денег")]
    [SerializeField] private int money;
    public int Money
    {
        get { return money; }
        set { money = money + value; }
    }



}
