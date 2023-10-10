using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStay : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject[] enemySpawners; 

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            door.GetComponent<DoorOpened>().enabled = true;
            for(int i = 0; i < enemySpawners.Length; i++)
            {
                enemySpawners[i].GetComponent<EnemySpawner>().enabled = true;
            }
        }
    }
}
