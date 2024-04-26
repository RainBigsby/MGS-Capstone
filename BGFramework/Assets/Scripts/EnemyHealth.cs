using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int totalHp = 5;

    // Update is called once per frame
    void Update()
    {
        if(totalHp == 0)
        {
            ScoreSystem.scoreValue += 1;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Projectile"))
        {
            totalHp--;
        }
    }
}
