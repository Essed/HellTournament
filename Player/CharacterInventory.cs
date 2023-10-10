using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour {

    public WeaponData firstWeapon; // Первый слот
    public WeaponData secondWeapon; // Второй слот 
    public GameObject objWeapon; // текущее оружие   

    private void Start()
    {
        objWeapon = Instantiate(firstWeapon.Gun);
        objWeapon.transform.parent = gameObject.transform;
        objWeapon.transform.localPosition = firstWeapon.weapon_pos;
        objWeapon.transform.localRotation = Quaternion.Euler(firstWeapon.weapon_rot);
    }

    public void SelectWeapon(int selectWeapon)
    {
        if (selectWeapon == 1)
        {
            objWeapon = Instantiate(firstWeapon.Gun);
            objWeapon.transform.parent = gameObject.transform;
            objWeapon.transform.localPosition = firstWeapon.weapon_pos;
            objWeapon.transform.localRotation = Quaternion.Euler(firstWeapon.weapon_rot);
        }
        

        if (selectWeapon == 2)
        {           
            objWeapon = Instantiate(secondWeapon.Gun);
            objWeapon.transform.parent = gameObject.transform;
            objWeapon.transform.localPosition = secondWeapon.weapon_pos;
            objWeapon.transform.localRotation = Quaternion.Euler(firstWeapon.weapon_rot);
        }
       
    }   

    public void DestroyWeapon()
    {
        objWeapon = GameObject.FindGameObjectWithTag("Weapon");

        Destroy(objWeapon);
    }
}
