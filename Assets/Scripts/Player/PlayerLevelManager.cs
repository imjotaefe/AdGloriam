using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLevelManager : MonoBehaviour
{
    [SerializeField] private FloatReference playerXp;
    public int currentLevel;
    [SerializeField] private TextMeshProUGUI levelText;

    private void Start()
    {
        levelText.text = "0";
    }

    public void UpdateLevel()
    {
        currentLevel++;
        levelText.text = currentLevel.ToString("0");
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
