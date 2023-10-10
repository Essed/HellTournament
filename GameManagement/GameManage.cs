using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    private void Start()
    {
      PlayerFind();
    }      

    // Метод поиска игрока
    public GameObject PlayerFind()
    {       
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        return player;
    }  

}
