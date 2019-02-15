using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.score >= 80)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
