using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClosed : MonoBehaviour
{
    [SerializeField] private float step; // величина шага

    private float progress; // прогресс

    [SerializeField] private Vector3 endPostion; // конечная позиция двери
    [SerializeField] private WaveManager door;

    private void FixedUpdate()
    {
        if (door.nextDoor)
        {
            transform.position = Vector3.Lerp(transform.position, endPostion, progress);

            progress += step;
        }
    }
}
