using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Vector2 movement = new Vector2(1f, 0.75f);
    public int moveSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = movement * moveSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Enemy"))
    //    {
    //       GameObject enemy = collision.gameObject;
    //        Destroy(enemy);
    //    }
    //}
}
