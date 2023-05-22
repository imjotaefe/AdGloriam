using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Vector3 PlayerPosition;
    public static Transform PlayerTransform;
    [SerializeField] public Animator playerAnimator;
    public FloatReference playerHp;
    public bool isDied;
    public static PlayerHealthController playerHealthController;
    public static PlayerLevelManager playerLevelManager;

    private void Awake()
    {
        playerHealthController = FindObjectOfType<PlayerHealthController>();
        playerLevelManager = FindObjectOfType<PlayerLevelManager>();
    }

    void FixedUpdate()
    {
        PlayerPosition = transform.position;
        PlayerTransform = transform;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("I am a regular Automatic Layout Button"))
        {
            playerAnimator.SetBool("DIED", true);
        }
    }
}
