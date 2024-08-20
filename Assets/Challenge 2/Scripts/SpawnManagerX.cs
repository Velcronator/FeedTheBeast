using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.2f;
    private float spawnInterval = 2.0f;
    private float spawnIntervalVariance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBallWithDelay());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBallWithDelay()
    {
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            SpawnRandomBall();

            float randomInterval = Random.Range(spawnInterval - spawnIntervalVariance, spawnInterval + spawnIntervalVariance);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
