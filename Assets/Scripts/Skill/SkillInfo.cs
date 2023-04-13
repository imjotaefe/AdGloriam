using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "New Skill")]
public class SkillInfo : ScriptableObject
{
    [SerializeField] public SkillType type;
    [SerializeField] public string skillName;
    [SerializeField] public string skillDescription;
    [SerializeField] private int level;
    [SerializeField] private List<float> value = new List<float>();
    [SerializeField] private List<float> coolDown = new List<float>();
    [SerializeField] private bool startAvailable;
    [SerializeField] private bool isActive;
    public float GetCurrentCoolDown () => coolDown[level];
}
