using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Animals;
    private const float xRange = 10;
    private const float SpawnPointZ = 25;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 1f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimals()
    {
        int randamils = Random.Range(0, Animals.Length);
        Instantiate(Animals[randamils], new Vector3(Random.Range(-xRange, xRange), 0, SpawnPointZ), 
            Animals[randamils].transform.rotation);
    }
}
