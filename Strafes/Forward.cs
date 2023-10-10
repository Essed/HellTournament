using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rigidBody;

    private void OnTriggerEnter(Collider col)
    {
        ColliderEnter(col);
    }

    // Метод входа в коллайдер
    private void ColliderEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GameObject character = col.gameObject;
            Rigidbody moveForce = col.GetComponent<Rigidbody>();

            ForwardStrafe(transform.GetChild(0).gameObject, character, moveForce);
        }
    }

    // Метод стрэйфа вперед
    private void ForwardStrafe(GameObject _sprite, GameObject character, Rigidbody _moveForce)
    {        
        character.transform.forward = new Vector3(0, 0, -_sprite.transform.position.z);

       _moveForce.AddForce(character.transform.forward * speed, ForceMode.Impulse);        
    }
}
