using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0F;
    private Vector3 moveDirection = Vector3.zero;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform playerTrail;
    [SerializeField] private Player player;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate ()
    {
        if (player.isDied)
        {
            controller.Move(Vector3.zero);
            return;
        }
        
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        
        if (moveDirection != Vector3.zero)
        {
            playerTransform.rotation =
                Quaternion.Slerp(playerTransform.rotation, Quaternion.LookRotation(moveDirection), 0.15f);
        }

        moveDirection.y = -10;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
        
        player.playerAnimator.SetBool("RUNNING", moveDirection.x != 0 || moveDirection.z != 0);
        
        playerTrail.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
    }
}
