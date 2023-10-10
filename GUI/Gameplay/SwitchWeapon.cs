using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchWeapon : MonoBehaviour
{
    [SerializeField] private GameObject GameManager;
    [SerializeField] private GameObject player;
    [SerializeField] private Button buttonFirst;
    [SerializeField] private Button buttonSecond;
    [SerializeField] private CharacterInventory inventory;   

    public void SelectWeaponFirst()
    {
        player = GameManager.GetComponent<GameManage>().PlayerFind();

        PlayerController playerWeapon = player.GetComponent<PlayerController>();      
      
        if (playerWeapon.selWeapon != 1)
        {
           int gun = player.GetComponent<PlayerController>().selWeapon = 1;

            player.GetComponent<CharacterInventory>().DestroyWeapon();
            player.GetComponent<CharacterInventory>().SelectWeapon(gun);            

            buttonFirst.gameObject.SetActive(false);
            buttonSecond.gameObject.SetActive(true);      

        }        
    }

    public void SelecWeaponSecond()
    {
        player = GameManager.GetComponent<GameManage>().PlayerFind();

        PlayerController playerWeapon = player.GetComponent<PlayerController>();        

        if (playerWeapon.selWeapon != 2)
        {  
            int gun = player.GetComponent<PlayerController>().selWeapon = 2;

            player.GetComponent<CharacterInventory>().DestroyWeapon();
            player.GetComponent<CharacterInventory>().SelectWeapon(gun);

            buttonFirst.gameObject.SetActive(true);
            buttonSecond.gameObject.SetActive(false);
        }
    }

}
