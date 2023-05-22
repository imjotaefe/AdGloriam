using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpOrb : MonoBehaviour
{
    public float orbXp;
    public ObjectPool orbXpPool;
    
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerLevelManager>();
        player.GainXp(orbXp);
        orbXpPool.RemoveFromPool(gameObject);
    }

}
