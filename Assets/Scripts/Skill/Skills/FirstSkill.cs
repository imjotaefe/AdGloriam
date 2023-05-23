using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstSkill : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private ObjectPool skillPool;
    
    protected override void FireSkill()
    {
        base.FireSkill();
        Collider[] hitColliders = Physics.OverlapSphere(Player.PlayerPosition, 15f, LayerMask.GetMask("Enemy"));
        if (hitColliders.Length == 0) return;
        var skill = skillPool.PopulatePool(skillPrefab);
        var skillBehaviour = skill.GetComponent<FirstSkillBehaviour>();
        skillBehaviour.FireSkill(hitColliders[0].transform);
    }
}
