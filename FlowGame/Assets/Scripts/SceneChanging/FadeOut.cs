using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{


    public Texture2D fadeOutTexture;            // texture that will overlay on screen 
    public float fadeSpeed = .08f;              // fading speed

    private int drawDepth = -1000;              // texture's order in the hierarchy: lower means renders on top
    private float alpha = 0f;                 // texture's alpha value between 0 and 1
    private int fadeDir = -1;                   // direction to fade: in = -1 or out = 1

    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    void Start()
    {
        BeginFade(1);
    }

}

