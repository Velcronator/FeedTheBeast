using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    [SerializeField] float startDelay = 2f;
    [SerializeField] float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0,
        spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnpos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
