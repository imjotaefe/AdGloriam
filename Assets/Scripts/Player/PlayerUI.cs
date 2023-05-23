using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider hpIndicator;
    [SerializeField] private Slider manaIndicator;
    [SerializeField] private Slider xpIndicator;
    public FloatReference playerHp;
    public FloatReference playerMana;
    public FloatReference playerXp;

    private void Update()
    {
        hpIndicator.value = playerHp.Value;
        manaIndicator.value = playerMana.Value;
        xpIndicator.value = playerXp.Value;
    }
}
