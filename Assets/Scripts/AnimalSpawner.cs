using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public Transform cow, deer, dog, horse;
    public float spawnInterval = 2f;
    public float spawnPosZ = 6;
    float time = 0f;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 2)
        {
            time = 0;
            int animalIndex = Random.Range(1, 5);
            if (animalIndex == 1) Spawn(cow);
            else if (animalIndex == 2) Spawn(deer);
            else if (animalIndex == 3) Spawn(dog);
            else if (animalIndex == 4) Spawn(horse);
        }
    }

    void Spawn(Transform animal)
    {
        float spawnPosX = Random.Range(-18,18);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(animal, spawnPos, animal.rotation);
    }
}
