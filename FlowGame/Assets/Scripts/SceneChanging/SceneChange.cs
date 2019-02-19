using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public string newScene;
    public float changeTime;

    public GameObject fadeout;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(WaitAndChange());
        }
    }


    IEnumerator WaitAndChange()
    {
        fadeout.SetActive(true);

        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadScene(newScene);
    }
}