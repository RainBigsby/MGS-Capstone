using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KnowledgeDrop : MonoBehaviour
{
    public int respawnScene;
    public PauseMenu kDrop;
    public int ScoreGoal;

    void Update()
    {
        ScoreTrigger();
    }

    public void RestartGame()
    {
        ScoreSystem.scoreValue = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // trigger knowledge drop
            kDrop.PauseGame();
        }
    }

    void ScoreTrigger()
    {
        if(ScoreSystem.scoreValue == ScoreGoal)
        {
            // trigger knowledge drop
            kDrop.PauseGame();
        }
    }
}
