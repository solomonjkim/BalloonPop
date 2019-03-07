using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnRadius = 5;
    public float secondsBetweenSpawns = 3;
    private float secondsSinceLastSpawn;

    void SpawnObject()
    {
        int objectIdx = Mathf.RoundToInt(Random.value);
        GameObject newObject = Instantiate(objectsToSpawn[objectIdx].gameObject, transform);
        newObject.transform.Translate(new Vector3(spawnRadius, 0, 0));

        newObject.transform.RotateAround(transform.position, Vector3.up, Random.value * 360);

        secondsSinceLastSpawn = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        secondsSinceLastSpawn += Time.deltaTime;

        if(secondsSinceLastSpawn >= secondsBetweenSpawns)
        {
            SpawnObject();
        }
    }
}
