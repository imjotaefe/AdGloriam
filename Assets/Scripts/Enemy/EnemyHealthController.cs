using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    
    [Space]
    // [SerializeField] private GameEvent OnEnemyTakeDamage;
    // [SerializeField] private GameEvent OnEnemyDie;
    private XpOrbManager xpOrbManager;
    private EnemySpawnManager _enemySpawnManager;
    
    private void Start()
    {
        xpOrbManager = FindObjectOfType<XpOrbManager>();
        _enemySpawnManager = FindObjectOfType<EnemySpawnManager>();
    }

    public void ReduceEnemyHp(float damage)
    {
        var newEnemyHp = enemy.currentEnemyHp - damage;
        // OnEnemyTakeDamage.Raise();
        if (newEnemyHp <= 0)
        {
            KillTheEnemy();
            return;
        }
        enemy.currentEnemyHp = newEnemyHp;
    }
    
    private void KillTheEnemy()
    {
        // enemy.playerAnimator.SetBool("DIED", true);
        xpOrbManager.SpawnOrb(enemy.monsterXp, transform.position);
        enemy.isDied = true;
        _enemySpawnManager.enemyPool.RemoveFromPool(gameObject);
        // OnEnemyDie.Raise();
    }
}
