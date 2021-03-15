using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        float randomInterval = Random.Range(4.5f, 10.0f);
        InvokeRepeating("SpawnRandomVehicle", 4.0f, randomInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomVehicle()
    {
        int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
        Vector3 startingPos = new Vector3(-28, 0, -35);
        Instantiate(vehiclePrefabs[vehicleIndex], startingPos, vehiclePrefabs[vehicleIndex].transform.rotation);
    }
}
