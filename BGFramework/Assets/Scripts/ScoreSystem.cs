using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int highScore;
    public bool showScore;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(showScore)
        {
            score.text = "SCORE: " + scoreValue;
        }
    }
}
