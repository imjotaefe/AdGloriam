using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLevelManager : MonoBehaviour
{
    public float currentXp;
    public int currentLevel;
    
    public void UpdateLevel()
    {
        currentLevel++;
    }

    public void GainXp(float earnedXp)
    {
        var newXp = currentXp + earnedXp;
        if (newXp >= 100)
        {
            currentXp = newXp - 100;
            UpdateLevel();
            return;
        }
        currentXp = newXp;
    }
}
