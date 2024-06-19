using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.15f;
    public Transform foodPrefab;

    private Animator playerAnimator;

    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update() 
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0 , 0);
        transform.position += move * speed * Time.deltaTime;

        if (move.x > 0) playerAnimator.Play("WalkRight");
        else if (move.x < 0) playerAnimator.Play("WalkLeft");
        else playerAnimator.Play("Idle");

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            ThrowFood();
        }
    }

    void ThrowFood()
    {
        playerAnimator.Play("ThrowFood");
        Instantiate(foodPrefab, this.transform.position, Quaternion.identity);
    }
}
