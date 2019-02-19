using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.
    public Text curentScore;                      // Reference to the Text component.
    public Text highScore;

    //GameObject player = GameObject.Find("Player");
    void Awake()
    {
        // Set up the reference.
       // curentScore = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("MOST ELIMINATED:", 0).ToString();    
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.

        curentScore.text = "DROIDS ELIMINATED: " + score;

        PlayerPrefs.SetInt("MOST ELIMINATED:", score);
    }

}