using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerBehaviour : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public int rotationIndex = 15;
    private Collider2D bullet;
    public LayerMask bulletsLayer;
    public Transform deflectPoint;
    public float dPointSize = 0.4f;
    Vector2 mousePosition;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        RotatoPotato();

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Swing");
            SwingerOfThings();
        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void RotatoPotato()
    {
        direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;

    }
    void SwingerOfThings()
    {
        bullet = Physics2D.OverlapCircle(deflectPoint.position, dPointSize, bulletsLayer);
        if(bullet != null)
        {
            Transform bulletLocation = bullet.GetComponent<bulletPhysics>().bullet.transform;
            bullet.GetComponent<bulletPhysics>().bullet.velocity = direction * 100 *Time.deltaTime;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(deflectPoint.position, dPointSize);
    }
}
