using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float hight;

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

            JumpUp(gameObject, character, moveForce);
        }
    }

    // Метод подлета вверх
    private void JumpUp(GameObject _sprite, GameObject character, Rigidbody _moveForce)
    {
        character.transform.up = new Vector3(0, -_sprite.transform.position.y, 0);

        _moveForce.AddForce(character.transform.up * hight, ForceMode.Impulse);
    }
}
