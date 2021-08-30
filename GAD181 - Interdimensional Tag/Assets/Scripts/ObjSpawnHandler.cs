using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnHandler : MonoBehaviour
{
    public GameObject[] spawnItem;
    public float spawnTiming;
    public float spawnFrequency;


    public int numberOfSpawnPoints; // the number of spawn points for a given map.
    public Transform[] mapSpawnLocation; // = new Transform[numberOfSpawnPoints]; // vector3 array representing those spawn point positions.
    public List<Vector3> spawnLocation = new List<Vector3>();

    ObjSpawnHandler secondarySpawner;

    void Start()
    {
        spawnTiming = Random.Range(3f, 6f);
        spawnFrequency = Random.Range(1f, 3f);

        //mapSpawnLocation = new Transform[numberOfSpawnPoints];

        for (int i = 0; i < numberOfSpawnPoints; i++)
        {
            spawnLocation.Add(new Vector3());
            mapSpawnLocation[i] = GetComponent<Transform>();
        }

        InvokeRepeating("Spawn", spawnTiming + 2, spawnTiming);
    }

    void Update()
    {

    }

    void Spawn()
    {
        for (int i = 0; i < spawnFrequency; i++)
        {


            if (spawnItem[i].CompareTag("Power Up"))
            {
                Instantiate(spawnItem[i], mapSpawnLocation[Random.
                    Range(0, numberOfSpawnPoints)]);
            }
            if (spawnItem[i].CompareTag("Portal"))
            {
                //spawnItem.Find("Portal A").gameObject;
            }
        }
        spawnTiming = Random.Range(3f, 6f);
        spawnFrequency = Random.Range(1f, 3f);
    }
}
