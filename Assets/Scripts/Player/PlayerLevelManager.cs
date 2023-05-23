using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLevelManager : MonoBehaviour
{
    [SerializeField] private FloatReference playerXp;
    public int currentLevel;
    
    public void UpdateLevel()
    {
        currentLevel++;
    }

    public void GainXp(float earnedXp)
    {
        var newXp = playerXp.Value + earnedXp;
        if (newXp >= 100)
        {
            playerXp.SetValue(newXp - 100);
            UpdateLevel();
            return;
        }
        playerXp.SetValue(newXp);
    }
}
