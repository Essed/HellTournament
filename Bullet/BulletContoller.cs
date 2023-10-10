using UnityEngine;

public class BulletContoller : MonoBehaviour
{
    public float speed; // скорость пули
    public float MaxDistance; // максимальная дальность пули
    private float curDistance; // текущая дальность 
    public float damage; // урон

    private Rigidbody rb;
    [SerializeField] private WeaponData damageData;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        damage = damageData.Damage;
    }  

    private void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Enemy")
        {           
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {            
            Destroy(gameObject);           
        }
    }  

    // Метод перемещения пули
    private void Move()
    {
        rb.AddForce(transform.forward * speed * Time.fixedDeltaTime);

        curDistance += Time.fixedDeltaTime;

        if (curDistance >= MaxDistance)
        {
            Destroy(gameObject);            
        }
    } 
}

