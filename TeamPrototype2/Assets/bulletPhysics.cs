using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    public Rigidbody2D bullet;
    private Vector2 movement = new Vector2(1f, 0f);
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
}
