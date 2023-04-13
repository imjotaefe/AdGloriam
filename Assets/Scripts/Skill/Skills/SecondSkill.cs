using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondSkill : Skill
{
    [SerializeField] private GameObject skillPrefab;
    [SerializeField] private ObjectPool skillPool;
    
    protected override void FireSkill()
    {
        base.FireSkill();
        //get enemies with raycast
        var skill = skillPool.PopulatePool(skillPrefab);
        var skillBehaviour = skill.GetComponent<SecondSkillBehaviour>();
        skillBehaviour.FireSkill();
    }
}
