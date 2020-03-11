using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Vector2 movement = new Vector2(1f, 0.75f);
    public int moveSpeed = 100;
    public GameObject self;

    public AudioClip ouchSound;
    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = movement * moveSpeed * Time.deltaTime;

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = ouchSound;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<playerBehaviour>().hitPoints--;
            
            GetComponent<AudioSource>().Play();
            Destroy(self, 0.1f);
        }
        if (collision.CompareTag("BulletDest"))
        {
            Destroy(self);
        }
    }
}
