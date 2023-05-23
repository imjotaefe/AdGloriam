using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class EnemySpawnManager : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    [SerializeField] public ObjectPool enemyPool;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);
        var createdEnemy = enemyPool.PopulatePool(enemies[Random.Range(0,2)].gameObject);
        createdEnemy.GetComponent<Enemy>().ResetEnemy();
        StartCoroutine(SpawnEnemy());
    }
}
