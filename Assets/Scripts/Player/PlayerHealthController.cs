using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerHealthController : MonoBehaviour
{
    [SerializeField] private Player player;
    
    [SerializeField] private FloatReference playerHp;
    [SerializeField] private FloatReference playerMp;
    
    [Space]
    [SerializeField] private GameEvent OnPlayerTakeDamage;
    [SerializeField] private GameEvent OnPlayerDie;

    public void ReducePlayerHp(float damage)
    {
        playerHp.SetValue(playerHp.Value - damage);
        OnPlayerTakeDamage.Raise();
        if (playerHp.Value <= 0)
        {
            KillThePlayer();
        }
    }
    
    public void ReducePlayerMp(float value)
    {
        playerMp.SetValue(playerMp.Value - value);
        OnPlayerTakeDamage.Raise();
    }
    
    public void KillThePlayer()
    {
        player.playerAnimator.SetBool("DIED", true);
        player.isDied = true;
        OnPlayerDie.Raise();
    }
    
}
