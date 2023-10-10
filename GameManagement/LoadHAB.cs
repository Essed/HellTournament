using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHAB : MonoBehaviour
{
    [SerializeField] private GameObject prefabLvl;

    private void Start()
    {
        Instantiate(prefabLvl, transform.position, prefabLvl.transform.rotation);
    }

}
