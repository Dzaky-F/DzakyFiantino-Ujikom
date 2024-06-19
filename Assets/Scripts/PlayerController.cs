using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    private CharacterController characterController;
    private Animator playerAnimator;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update() 
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,0);
        characterController.Move(move * speed * Time.deltaTime);

        if (move.x > 0) playerAnimator.Play("WalkRight");
        else if (move.x < 0) playerAnimator.Play("WalkLeft");
        else playerAnimator.Play("Idle");
    }
}
