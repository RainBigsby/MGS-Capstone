using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int respawnScene;
    public PauseMenu kDrop;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // check if knowledge drop exists
            if (kDrop != null)
            {
                // trigger knowledge drop game over screen
                kDrop.PauseGame();
            }

            // otherwise, trigger game over without knowledge drop
            else
            {
                SceneManager.LoadScene(respawnScene);
            }
        }
    }
}
