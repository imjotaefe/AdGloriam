using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float moveSpeed;
    private NavMeshAgent navMeshAgent;
    [SerializeField] private PlayerHealthController playerHealthController;
    
    
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        var minDistance = 3;
        float dist = Vector3.Distance(transform.position, player.position);
        if (dist > minDistance)
        {
            navMeshAgent.isStopped = false;
            navMeshAgent.destination = new Vector3(player.position.x +0.3f, player.position.y, player.position.z +0.3f);
            return;
        }
        navMeshAgent.isStopped = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            playerHealthController.ReducePlayerHp(10);
        }
    }
}
