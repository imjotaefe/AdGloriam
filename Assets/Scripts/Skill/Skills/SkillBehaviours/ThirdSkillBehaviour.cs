using System.Collections;
using UnityEngine;

public class ThirdSkillBehaviour: MonoBehaviour
{
    [SerializeField] public ObjectPool skillPool;

    public void FireSkill()
    {
        transform.position = new Vector3(Player.PlayerPosition.x, 0, Player.PlayerPosition.z);
        StartCoroutine(DestroyThisObject());
    }

    private IEnumerator DestroyThisObject()
    {
        yield return new WaitForSeconds(3);
        // Destroy(gameObject);
        skillPool.RemoveFromPool(gameObject);
    }
}
