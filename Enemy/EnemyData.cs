using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Enemies/Enemy", fileName = "New Enemy")]
public class EnemyData : ScriptableObject {

    [Tooltip("Здоровье")]
    [SerializeField] private int fullHp;
    public int FullHp
    {
        get { return fullHp; }

        set { fullHp = value; }
    }

    [Tooltip("Противник")]
    [SerializeField] private GameObject enemy;
    public GameObject Enemy
    {
        get { return enemy; }      
    }
       
    [Tooltip("Ранг врага")]
    [SerializeField] private float rank;
    public float Rank
    {
        get { return rank; }       
    }

    [Tooltip("Скорость вращения")]
    [SerializeField] private float speedRotation;
    public float SpeedRotation
    {
        get { return speedRotation; }
    }

    [Tooltip("Скорость угловая")]
    [SerializeField] private float angularSpeed;
    public float AngularSpeed
    {
        get { return angularSpeed; }
    }

    [Tooltip("Скорость")]
    [SerializeField] private float speed;
    public float Speed
    {
        get { return speed; }
    }

    [Tooltip("Урон")]
    [SerializeField] private float damage;
    public float Damage
    {
        get { return damage; }
    }

    [Tooltip("Ускорение")]
    [SerializeField] private float acceleration;
    public float Acceleration
    {
        get { return acceleration; }
    }

    [Tooltip("Количество очков за убийство")]
    [SerializeField] private int score;
    public int Score
    {
        get { return score; }        
    }
}
