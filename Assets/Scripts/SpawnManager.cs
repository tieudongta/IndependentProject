using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    public GameObject[] vehiclePrefabs1;
    private CarController carCtrl;
    // Start is called before the first frame update
    void Start()
    {
        carCtrl = GameObject.Find("Player").GetComponent<CarController>();
        float randomInterval = Random.Range(10.5f, 20.0f);
        InvokeRepeating("SpawnRandomVehicle", 10.0f, randomInterval);
        InvokeRepeating("SpawnRandomVehicle1", 6.0f, randomInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomVehicle()
    {
        if (!carCtrl.gameOver)
        {
            int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
            Vector3 startingPos = new Vector3(-13, 0, -60);
            Instantiate(vehiclePrefabs[vehicleIndex], startingPos, vehiclePrefabs[vehicleIndex].transform.rotation);
        }
    }
    void SpawnRandomVehicle1()
    {
        if (!carCtrl.gameOver)
        {
            int vehicleIndex = Random.Range(0, vehiclePrefabs1.Length);
            Vector3 startingPos = new Vector3(-110, 0, -20);
            Instantiate(vehiclePrefabs1[vehicleIndex], startingPos, vehiclePrefabs1[vehicleIndex].transform.rotation);
        }
    }
}
