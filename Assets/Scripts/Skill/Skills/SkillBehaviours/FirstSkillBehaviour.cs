using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkillBehaviour : MonoBehaviour
{
    private Rigidbody _rigidBody;
    [SerializeField] private ParticleSystem explosionParticle;
    [SerializeField] public ObjectPool skillPool;
    [SerializeField] private float speed = 15f;
    
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void FireSkill(Transform enemy)
    {
        var initialPosition = new Vector3(Player.PlayerPosition.x, Player.PlayerPosition.y +1, Player.PlayerPosition.z);
        transform.position = initialPosition;
        var targetPosition = new Vector3(enemy.position.x, enemy.position.y + 1, enemy.position.z);
        
        var direction = (targetPosition - initialPosition).normalized;
        _rigidBody.velocity = direction * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        explosionParticle.Play();
        StartCoroutine(DestroyThisObject());
    }

    private IEnumerator DestroyThisObject()
    {
        yield return new WaitForSeconds(1);
        // Destroy(gameObject);
        skillPool.RemoveFromPool(gameObject);
    }
}
