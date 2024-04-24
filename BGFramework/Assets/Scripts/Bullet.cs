using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddRelativeForce(new Vector3(0, speed));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // destroy bullet
        Destroy(gameObject);
    }
}
