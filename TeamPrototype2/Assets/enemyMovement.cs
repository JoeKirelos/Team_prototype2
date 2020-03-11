using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //public GameObject spawner;
    public Rigidbody2D enemy;
    public Vector2 movement = new Vector2(1f, 0f);
    public int moveSpeed = 100;
    public GameObject self;
    public float travelTime = 1f;

    public AudioClip boppingSound;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Run", 0.1f);

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = boppingSound;

    }

    // Update is called once per frame
    void Update()
    {
    }

    void Run()
    {
        enemy.velocity = movement * moveSpeed* Time.deltaTime;
        Invoke("Switch", travelTime);
    }
    void Switch()
    {
        moveSpeed = -moveSpeed;
        Invoke("Run", 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        Destroy(self, 0.5f);
    }
}
