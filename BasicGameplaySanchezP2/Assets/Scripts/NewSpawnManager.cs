using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 14;
    private float spawnPosZ = 20;
    private float spawnPosX = 20;
    private int spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationLeft = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationLeft);
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationRight = Quaternion.Euler(0, 270, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationRight);
    }
}
