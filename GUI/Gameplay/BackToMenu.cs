using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMenu : MonoBehaviour
{
    [SerializeField] WeaponData[] guns;
    public  void ExitGameplay()
    {
        for(int i = 0; i<guns.Length; i++)
        {
            guns[i].CurCutridge = guns[i].FullCutridge;
            guns[i].CurAmmo = guns[i].FullAmmo;
        }

        Time.timeScale = 1;       
        SceneManager.LoadScene(0);
    }
}
