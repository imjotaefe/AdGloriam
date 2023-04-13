using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> pool;
    
    public GameObject PopulatePool(GameObject element)
    {
        var poolObject = pool.FindLast(item => item.activeSelf == false);
        if (poolObject)
        {
            poolObject.SetActive(true);
            return poolObject;
        }
        var newInstance = Instantiate(element, transform);
        pool.Add(newInstance);
        return newInstance;
    }

    public void RemoveFromPool(GameObject element)
    {
        if (pool.Count <= 0) return;
        var poolObject = pool.Find(item => item == element);
        if (poolObject)
        {
            poolObject.SetActive(false);
        }
    }
}
