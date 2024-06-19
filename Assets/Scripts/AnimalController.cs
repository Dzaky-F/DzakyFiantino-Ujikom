using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public float speed = 0.5f;
    public float hunger = 100;
    public float score;

    void Start()
    {
        speed /= 75f;
    }

    void Update()
    {
        transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        if (hunger == 0) Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food") {
            hunger -= 25;
        }
        
    }
}
