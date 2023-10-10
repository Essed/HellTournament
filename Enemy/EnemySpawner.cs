using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{  
    [SerializeField] private float timeBetweenSpawn; // время между спавнами противников
    [SerializeField] private float spawnTimer; // таймер спавна
    [SerializeField] private int currentCountEnemy; // текущее количество противников в пуле

    // Ссылки
    [SerializeField] private WaveManager Manager; // ссылка на игровой менеджер
    [SerializeField] private EnemyData[] enemySettings; // пул с противникам
    [SerializeField] private GameObject[] enemies; // текущий пул с противниками 

    private GameObject enemyPrefab; // префаб противника   

    private void Start()
    {        
        spawnTimer = Manager.timeToSpawn;            
    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(currentCountEnemy == Manager.maxEnemy)
        {              
            if(enemies.Length == 0)
            {
                Manager.nextDoor = true;
                this.enabled = false;
            }
        }

        if (spawnTimer <= 0.0f && currentCountEnemy <= Manager.maxEnemy)
        {
            StartCoroutine(Spawn());
            spawnTimer = Manager.timeToSpawn;
        }
        else if (spawnTimer >= 0.0f && currentCountEnemy == Manager.maxEnemy)
        {
            spawnTimer = Manager.timeToSpawn;
        }

        else
        {
            spawnTimer -= Time.deltaTime;
        }        
    }

    private IEnumerator Spawn()
    {       
        yield return new WaitForSeconds(timeBetweenSpawn);

        enemyPrefab = Instantiate(enemySettings[Random.Range(0, enemySettings.Length)].Enemy, transform.position, transform.rotation);        
        enemyPrefab.GetComponent<AIController>().enabled = true;

        currentCountEnemy++;        
    }    
   
}
