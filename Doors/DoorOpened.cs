using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpened : MonoBehaviour
{   
    [SerializeField] private float step; // величина шага    

    private float progress; // прогресс
    
    [SerializeField] private Vector3 endPostion; // конечная позиция двери    

    private void FixedUpdate()
    {        
            transform.position = Vector3.Lerp(transform.position, endPostion, progress);

            progress += step;
        
    }
}
