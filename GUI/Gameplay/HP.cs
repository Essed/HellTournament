using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform target;
    [SerializeField] private Image hpBar;

    private Vector3 offset;

    private void Start()
    {
        offset = target.position - player.transform.position;
    }

    private void Update()
    {
        hpBar.fillAmount = player.GetComponent<PlayerController>().hp;
        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
