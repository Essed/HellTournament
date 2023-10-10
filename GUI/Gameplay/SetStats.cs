using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetStats : MonoBehaviour
{
    [SerializeField] private WriteStats writer;

    [SerializeField] private Text killStat;
    [SerializeField] private Text money;

    private void Update()
    {
        if (gameObject.name == "Kill Stat") KillStat();

        else Money();
    }


    private void KillStat()
    {
        killStat.text = (writer.KillFull / 2).ToString();
    }

    private void Money()
    {
        money.text = writer.Money.ToString();
    }

}
    