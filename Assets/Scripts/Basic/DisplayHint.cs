/*
This script is used to display the FPS and parameter values on the UI.
*/


using System.Collections;
using TMPro;
using UnityEngine;

public class DisplayHint : MonoBehaviour
{


    public float updateInteval = 0.5f;

    private TextMeshProUGUI textOutput = null;

    private float deltaTime = 0.0f;
    private float milliseconds = 0.0f;
    private int framesPerSecond = 0;


    private void Awake()
    {
        textOutput = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        //CalculateCurrentFPS();
    }

    /*    //Calculate FPS
        private void CalculateCurrentFPS()
        {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
            milliseconds = (deltaTime * 1000.0f);
            framesPerSecond = (int)(1.0f / deltaTime);
        }

        private IEnumerator ShowHint()
        {
            while (true)
            {
                textOutput.text = "FPS: " + framesPerSecond + "\n"
                                + "MS: " + milliseconds.ToString(".0") + "\n";
                yield return new WaitForSeconds(updateInteval);
            }
        }*/


    void Disappear()
    {
        gameObject.SetActive(false);
    }

    public void Show(string str)
    {
        textOutput.text = str;
        gameObject.SetActive(true);
        Invoke("Disappear", 1f);
    }

}
