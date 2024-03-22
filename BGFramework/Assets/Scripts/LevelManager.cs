using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // where the player starts in the game i.e checkpoint
    [SerializeField]  private Vector3 respawnPoint;
    public GameObject fallDetector;

    // change scene name in inspector
    [SerializeField] public string sceneName;


    void Start()
    {
        // get the position of the player
        respawnPoint = transform.position;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        // when player enters goal
        if (collision.name == "Player")
        {
            Debug.Log("Player Hit Goal");

            // go to next level
            SceneManager.LoadScene(sceneName);
        }

        // if player falls off platforms
        if (collision.name == "FallDetector")
        {
            transform.position = respawnPoint;
        }
    }

    public void MoveToScene(int sceneID)
    { 
        SceneManager.LoadScene(sceneID);
    }
}