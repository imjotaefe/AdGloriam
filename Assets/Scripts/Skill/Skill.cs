using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] private SkillInfo skillInfo;
    [SerializeField] protected Player player;
    
    protected virtual void Start()
    {
        StartCoroutine(StartCoolDown());
    }

    private IEnumerator StartCoolDown()
    {
        if (player.isDied) yield break;
        yield return new WaitForSeconds(skillInfo.GetCurrentCoolDown());
        FireSkill();
        yield return StartCoolDown();
    }

    protected virtual void FireSkill(){}
}
