using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosY = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal),spawnDelay,spawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosY);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
