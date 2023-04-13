using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Slider hpIndicator;
    [SerializeField] private Slider manaIndicator;
    public FloatReference playerHP;
    public FloatReference playerMana;

    private void Update()
    {
        hpIndicator.value = playerHP.Value;
        manaIndicator.value = playerMana.Value;
    }
}
