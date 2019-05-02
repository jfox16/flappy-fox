using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ObstacleSpawner spawns obstacles at a regular rate.
public class ObstacleSpawner : MonoBehaviour
{
    bool isSpawning;
    [SerializeField] float spawnTime = 1;
    [SerializeField] float spawnRate = 1;
    [SerializeField] float heightRange = 1;
    [SerializeField] GameObject obstaclePrefab;

    void Update() {
        // When game first starts running, start the spawner.
        if (GameController.state == GameController.State.Running) {
            if (!isSpawning) {
                InvokeRepeating("SpawnObstacle", spawnTime, spawnRate);
                isSpawning = true;
            }
        }
        else {
            CancelInvoke();
        }
    }

    void SpawnObstacle() {
        // Randomizes the height of spawned obstacles within heightRange.
        float spawnY = Random.Range(-heightRange, heightRange);
        Vector3 spawnPosition = transform.position + new Vector3(0, spawnY, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
