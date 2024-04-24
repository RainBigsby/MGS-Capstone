using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ScoreSystem.scoreValue += 1;
            if (AudioManager.Instance != null)
                AudioManager.Instance.PlaySFX("star"); // Play the collect sound effect
            Destroy(gameObject);
        }
    }
}
