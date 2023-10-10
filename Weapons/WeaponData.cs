using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Weapon/Gun", fileName = "New Gun")]
public class WeaponData : ScriptableObject {    

    public Vector3 weapon_pos;
    public Vector3 weapon_rot; 

    [Tooltip("Модель оружия")]
    [SerializeField] private GameObject weaponPrefab;
    public GameObject Gun
    {
        get { return weaponPrefab; }
        protected set { }
    }

    [Tooltip("Пуля")]
    [SerializeField] private GameObject bullet;
    public GameObject Bullet
    {
        get { return bullet; }
        protected set { }
    }

    [Tooltip("Дальность стрельбы")]
    [SerializeField] private float range;
    public float Range
    {
        get { return range; }
        protected set { }
    }

    [Tooltip("Скорострельность")]
    [SerializeField] private float burstRate;
    public float BurstRate
    {
        get { return burstRate; }
        protected set { }
    }   

    [Tooltip("Таймер перезарядки")]
    [SerializeField] private float reloadTimer;
    public float ReloadTimer
    {
        get { return reloadTimer; }
        protected set { }
    }

    [Tooltip("Полные боеприпасы")]
    [SerializeField] private int fullAmmo;
    public int FullAmmo
    {
        get { return fullAmmo; }
        protected set { }
    } 

    [Tooltip("Полный запас патронов")]
    [SerializeField] private int fullCutridge;
    public int FullCutridge
    {
        get { return fullCutridge; }
        protected set { }
    }

    [Tooltip("Боеприпасы")]
    [SerializeField] private int curAmmo;
    public int CurAmmo
    {
        get { return curAmmo; }
        set { curAmmo = value;}
    }

    [Tooltip("Запас патронов")]
    [SerializeField] private int curCutridge;
    public int CurCutridge
    {
        get { return curCutridge; }
        set { curCutridge = value; }
    }

    [Tooltip("Урон")]
    [SerializeField] private float damage;
    public float Damage
    {
        get { return damage; }
        protected set { }
    }

    [Tooltip("Максильманый разброс")]
    [SerializeField] private float maxDisp;
    public float MaxDisp
    {
        get { return maxDisp; }
        protected set { }
    }

    [Tooltip("Минимальный разброс")]
    [SerializeField] private float minDisp;
    public float MinDisp
    {
        get { return minDisp; }
        protected set { }
    }

    [Tooltip("Точность")]
    [Range(0.0f, 1.0f)]
    [SerializeField] private float accuracy;
    public float Accuracy
    {
        get { return accuracy; }
        protected set { }
    }

    [Tooltip("Выстрелов за время")] 
    [SerializeField] private float rpt;
    public float Rpt
    {
        get { return rpt; }
        protected set { }
    }

    [Tooltip("Период времени")]
    [SerializeField] private float timePeriod;
    public float TimePeriod
    {
        get { return timePeriod; }
        protected set { }
    }

    [Tooltip("Автоматический режим")]
    [SerializeField] private bool auto;
    public bool Auto
    {
        get { return auto; }
        protected set { }
    }

    [Tooltip("Полуавтоматический режим")]
    [SerializeField] private bool semi;
    public bool Semi
    {
        get { return semi; }
        protected set { }
    }

    [Tooltip("Таймер автоматической перезарядки")]
    [SerializeField] private float secondsToReload;
    public float SecondsToReload
    {
        get { return secondsToReload; }
        protected set { }
    }


}
