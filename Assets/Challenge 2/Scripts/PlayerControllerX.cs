using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnDelay = 0.5f;
    private float lastSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog after 0.5 seconds
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = Time.time;
        }
    }
}
