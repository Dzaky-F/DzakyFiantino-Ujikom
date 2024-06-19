using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public float speed = 5;
    public float destroyAfter = 20;

    void Start()
    {
        // Destroy(gameObject, destroyAfter);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Food") Destroy(gameObject);
    }
}