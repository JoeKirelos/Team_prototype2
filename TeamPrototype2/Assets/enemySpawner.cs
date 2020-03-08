using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemyInstance;
    public Transform spawnPoint;
    public int enemyCounter = 1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Spawn()
    {
        if (enemyCounter == 0)
        {
            enemyInstance = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            enemyCounter = 1;
        }
        if (enemyInstance == null)
        {
            enemyCounter = 0;
        }
        Invoke("Spawn", 0);
    }
}
