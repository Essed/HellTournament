using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPause : MonoBehaviour
{
    [SerializeField] private GameObject pauseFrame;

    public void Pause()
    {
        pauseFrame.SetActive(true);
        Time.timeScale = 0;
        gameObject.SetActive(false);
    }
}
