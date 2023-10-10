using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPause : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject frame;
    
    public void ResPause()
    {
        pauseButton.SetActive(true);
        Time.timeScale = 1;

        frame.SetActive(false);
        
    }
}
