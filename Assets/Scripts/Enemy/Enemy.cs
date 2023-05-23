using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float monsterXp;
    public bool isDied;
    public float enemyHp;
    public float currentEnemyHp;
    
    public void ResetEnemy()
    {
        currentEnemyHp = enemyHp;
        isDied = false;
    }
}
