/*
This script is used to implement VR interaction(switch to DPM or CM using the controller buttons).
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Record : MonoBehaviour
{
    public GameObject camera1, camera2;
    public SwitchDPM switchDPM;
    public LightSizeChange lightSizeChange;

    private void Start()
    {

        switchDPM.SwitchToCM();
        //switchDPM.SwitchToDPM();
        lightSizeChange.flag = 2;
        Shader.SetGlobalFloat("lightsize", 0.2f);

        camera1.SetActive(false);
        camera2.SetActive(true);
        //Time.timeScale = 0.0f;
    }


    void Update()
    {


    }


    public void ToggleByMenu()
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
}
