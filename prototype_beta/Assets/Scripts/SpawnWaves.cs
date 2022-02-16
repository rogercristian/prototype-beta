using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaves : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform localToSpawn;
    public int enemyMax;
    [HideInInspector] public int currentEnemyCount; // Controla o maximo de inimigo spawmado  (é subtrado ao matar um inimigo)
    float timeToSpawn = 0f;
    public float  spawnTime = 2f;
    public int MaxNumberEnemy; // controla o total geral de inimigos que este sistema vai gerar. 
    int currentNumberEnemy;
    int deadTodestroy;
    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            for (int i = 0; i < enemyPrefab.Length; i++)
            {
                int randonN = Random.Range(0,enemyPrefab.Length);

                timeToSpawn = Time.time + spawnTime;
                if (currentEnemyCount < enemyMax && currentNumberEnemy <=MaxNumberEnemy)
                    {
                        Instantiate(enemyPrefab[randonN], localToSpawn.position, localToSpawn.rotation);
                        currentEnemyCount++;
                    currentNumberEnemy++;
                    deadTodestroy++;
                    } 
                 
            }
        }
         if (deadTodestroy == MaxNumberEnemy)
        {
            GameObject.Destroy(gameObject);
        }
    } 
}
