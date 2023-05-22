using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemySpawnManager : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    [SerializeField] private ObjectPool enemyPool;
    
    private void Start()
    {
        enemyPool.PopulatePool(enemies[0].gameObject);
    }
}
