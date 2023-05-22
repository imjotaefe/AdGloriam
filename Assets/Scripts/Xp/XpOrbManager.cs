using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpOrbManager : MonoBehaviour
{
    public ObjectPool orbXpPool;
    public XpOrb orbXpPrefab;
    
    public void SpawnOrb(float monsterXp, Vector3 enemyPosition)
    {
        orbXpPrefab.orbXp = monsterXp;
        orbXpPrefab.orbXpPool = orbXpPool;
        orbXpPool.PopulatePool(orbXpPrefab.gameObject, enemyPosition);
    }
}
