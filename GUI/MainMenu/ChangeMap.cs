using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMap : MonoBehaviour
{   
    
    [SerializeField] private int sceneID; // номер сцены

    [SerializeField] private GameObject characterPrefab; // префаб персонажа
    [SerializeField] private GameObject loadingDisplay; // загрузочный экран

    [SerializeField] SceneLoading nextScene; // ссылка на скрипт    

    // Загрузка уровня
    public void LoadLevel()
    {
        characterPrefab.SetActive(false);
        loadingDisplay.SetActive(true);
        nextScene.sceneID = sceneID;
    }
}
