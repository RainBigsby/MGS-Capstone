using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public delegate void UpdateHealthBar(int amount);
    public static event UpdateHealthBar UpdateHealth;


    [SerializeField] private int totalHp = 100;
    // change scene name in inspector
    [Header("Scene after player death")]
    [SerializeField] public string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (totalHp == 0)
        {
            Destroy(gameObject);
            // go to next level
            SceneManager.LoadScene(sceneName);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        { 
            Debug.Log("Player was hit");
            totalHp-=10;
        }
        UpdateHealth(totalHp);
    }
}
