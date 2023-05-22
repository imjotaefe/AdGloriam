using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3;
    private NavMeshAgent navMeshAgent;
    private Animator monsterAnimator;
    public Enemy enemy;
    private XpOrbManager xpOrbManager;
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        monsterAnimator = GetComponent<Animator>();
        enemy = GetComponent<Enemy>();
        xpOrbManager = FindObjectOfType<XpOrbManager>();
    }

    private void Update()
    {
        var minDistance = 3;
        float dist = Vector3.Distance(transform.position, Player.PlayerPosition);
        if (dist > minDistance)
        {
            navMeshAgent.isStopped = false;
            navMeshAgent.destination = new Vector3(Player.PlayerPosition.x +0.3f, Player.PlayerPosition.y, Player.PlayerPosition.z +0.3f);
            monsterAnimator.SetBool("RUNNING", true);
            return;
        }
        monsterAnimator.SetBool("RUNNING", false);
        navMeshAgent.isStopped = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            // Player.playerHealthController.ReducePlayerHp(10);
            xpOrbManager.SpawnOrb(enemy.monsterXp, transform.position);
        }
    }
}
