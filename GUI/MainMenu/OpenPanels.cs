using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanels : MonoBehaviour
{
    [SerializeField] private GameObject shopPanels; // панель магазина
    [SerializeField] private GameObject playPanels; // панель уровней
    [SerializeField] private GameObject dataPanels; // панель данных
    [SerializeField] private GameObject storagePanels; // панель склада
    [SerializeField] private GameObject optionsPanel; // панель склада

    // Открытие панели с выбором уровня
    public void OpenPlay()
    {        
        playPanels.SetActive(true);
        shopPanels.SetActive(false);
        dataPanels.SetActive(false);
        storagePanels.SetActive(false);
        optionsPanel.SetActive(false);
    }
    
    // Открытие панели с магазином
    public void OpenShop()
    {
        playPanels.SetActive(false);
        shopPanels.SetActive(true);
        dataPanels.SetActive(false);
        optionsPanel.SetActive(false);
        storagePanels.SetActive(false);
    }

    // Открытие панели со складом
    public void OpenStorage()
    {
        playPanels.SetActive(false);
        shopPanels.SetActive(false);
        dataPanels.SetActive(false);
        optionsPanel.SetActive(false);
        storagePanels.SetActive(true);

    }

    // Открытие панели с данными
    public void OpenData()
    {
        playPanels.SetActive(false);
        shopPanels.SetActive(false);
        dataPanels.SetActive(true);
        storagePanels.SetActive(false);
        optionsPanel.SetActive(false);
    }

    // Открытие панели настроек
    public void OpenOptions()
    {
        playPanels.SetActive(false);
        shopPanels.SetActive(false);
        dataPanels.SetActive(false);
        storagePanels.SetActive(false);
        optionsPanel.SetActive(true);
    }   

}
