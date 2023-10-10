using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private float reloadTimer; // время перезарядки
    private float secondsToAutoReload; // время автоматической перезарядки   
    private float nextTimeShot; // время следующего выстрела
    private float secondBetweenShot; // время между выстрелами
    private float minDisp; // минимальный разброс
    private float maxDisp; // минимальный разброс        
    

    [SerializeField] private WeaponData weaponData; // шаблон с настройками оружия
    [SerializeField] private LineRenderer sightLine; // прицел
    private GameObject bullet; // префаб пули 
    private Transform bulletSpawnPoint; // место спавна пулей    
    

    private void Awake()
    {
        reloadTimer = weaponData.ReloadTimer;
        secondsToAutoReload = weaponData.SecondsToReload;
        bullet = weaponData.Bullet;
        minDisp = weaponData.MinDisp;
        maxDisp = weaponData.MaxDisp;

        bulletSpawnPoint = transform.GetChild(0);
    }

    private void Start()
    {      
        SightRenderer();       
    }

    private void FixedUpdate()
    {
        if (weaponData.Semi) { SemiShoot(); }
        if (weaponData.Auto) { AutoShoot(); }
    }

    private void Update()
    {
        SetDisperionSettings();

        secondBetweenShot = weaponData.TimePeriod / weaponData.Rpt;         

        // Наличие патронов
        if (weaponData.CurAmmo <= 5)
        {
            if (secondsToAutoReload <= 0.0f)
            { Reload(); }

            else { secondsToAutoReload -= Time.deltaTime; }
        }

        if(reloadTimer > 0.0f)
        {
            reloadTimer -= Time.deltaTime; 
        }      

    }

    // Метод полуавтоматической стрельбы
    private void SemiShoot()
    {
        if (nextTimeShot > 0.0f) { nextTimeShot -= 0.5f; }
        else { nextTimeShot = weaponData.BurstRate; }

        if (weaponData.CurAmmo > 0.0f && reloadTimer <= 0.0f && nextTimeShot <= 0.0f)
        {
            RaycastHit hit;

            if (Physics.Raycast(bulletSpawnPoint.position, bulletSpawnPoint.forward, out hit, weaponData.Range))
            {
                if (hit.collider.tag == "Enemy")
                {
                    Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation * Quaternion.Euler(Random.Range(minDisp, maxDisp), Random.Range(minDisp, maxDisp), 0));

                    AmmoDecrease(1);
                }
            }           
        }
    }   

    // Метод автоматической стрельбы
    private void AutoShoot()
    {
        if (CanShoot())
        {
            if (weaponData.CurAmmo > 0.0f)
            {
                RaycastHit hit;

                if (Physics.Raycast(bulletSpawnPoint.position, bulletSpawnPoint.forward, out hit, weaponData.Range))
                {
                    if (hit.collider.tag == "Enemy")
                    {                       
                        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation * Quaternion.Euler(Random.Range(minDisp, maxDisp), Random.Range(minDisp, maxDisp), 0));

                        AmmoDecrease(1);
                    }
                }
                nextTimeShot = Time.time + secondBetweenShot;
            }
        }
    }

    // Метод уменьшения пуль в магазине
    private int AmmoDecrease(int amount)
    {
        if (weaponData.CurAmmo > 0)
        {
            weaponData.CurAmmo -= amount;
            return weaponData.CurAmmo;
        }

        else { return weaponData.CurAmmo; }
    }

    // Метод перезарядки
    private void Reload()
    {         
        // перезарядка с непоследним запасом патронов
        if (weaponData.CurCutridge >= weaponData.FullAmmo && secondsToAutoReload <= 0)
        {          
          int buffer = weaponData.FullAmmo - weaponData.CurAmmo;

          weaponData.CurAmmo += buffer;

          weaponData.CurCutridge -= buffer;           

          secondsToAutoReload = weaponData.SecondsToReload;        
        }

        // перезарядка с последним запасом патронов
        if (weaponData.CurCutridge < weaponData.FullCutridge  && secondsToAutoReload <= 0)
        {
           int buffer = weaponData.CurCutridge;

           weaponData.CurCutridge -= buffer;

           weaponData.CurAmmo += buffer;                      

           secondsToAutoReload = weaponData.SecondsToReload;           

        }  

    }

    // Метод инициализации настроек разброса
    private void SetDisperionSettings()
    {
        minDisp = weaponData.MinDisp * weaponData.Accuracy;
        maxDisp = weaponData.MaxDisp * weaponData.Accuracy;
    }       

    // Метод задержки между выстрелами
    private bool CanShoot()
    {
        bool canShoot = true;

        if(Time.time < nextTimeShot)
        {
            canShoot = false;
        }

        return canShoot;
    }

    // Метод отрисовки прицела
    private void SightRenderer()
    {
        sightLine.SetPosition(0, new Vector3(0,0,weaponData.Range));
    }
    
}
