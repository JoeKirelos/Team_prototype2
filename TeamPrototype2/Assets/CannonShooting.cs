using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{


    public Transform firePoint;
    public GameObject bulletPrefab;
    public float randomizer = 0.1f;
    public float equalizer;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", equalizer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shoot()
    {
        float shootInterval = Random.Range(2, 4);
        shootInterval += randomizer;
        Invoke("Shoot", shootInterval);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
