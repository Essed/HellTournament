using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
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

    // Метод стрэйфа влево
    private void ForwardStrafe(GameObject _sprite, GameObject character, Rigidbody _moveForce)
    {
        Vector3 direction = _sprite.transform.up;

        character.transform.right = -direction;

        _moveForce.AddForce(character.transform.right * speed, ForceMode.Impulse);
    }
}
