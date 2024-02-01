/*
This script is used to implement VR interaction(light size control using the controller buttons).
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSizeChange : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    //public InputActionReference lightSizeReference2 = null;

    //The temporary variable for the LightSize
    private float temp = 1.00f;

    //Display UI in VR that shows the FPS and parameter values
    public DisplayFPS displayFPS;
    public Transform light;

    public DisplayHint hint;


    public int flag = 0;
    
    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        flag++;
        if (flag == 3)
        {
            flag = 0;
        }

        if (flag == 0)
        {

            temp = 0.0f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);


        }
        else if (flag == 1)
        {
            temp = 0.1f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);

        }
        else if (flag == 2)
        {
            temp = 0.2f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);
        }
        hint.Show("Light Size Change");
    }

    public void ToggleByMenu()
    {

        flag++;
        if (flag == 3)
        {
            flag = 0;
        }

        if (flag == 0)
        {

            temp = 0.0f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);


        }
        else if (flag == 1)
        {
            temp = 0.1f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);

        }
        else if (flag == 2)
        {
            temp = 0.2f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);
        }
        hint.Show("Light Size Change");
    }

    /*    private void Update()
        {
            float value = lightSizeReference.action.ReadValue<float>();
            float value2 = lightSizeReference2.action.ReadValue<float>();
            UpdateLightSize(value);
            UpdateLightSize2(value2);
        }

        //Decrease the value of the LightSize variable
        private void UpdateLightSize(float value)
        {
            temp -= 0.01f * value;
            if (temp <= 0.00f)
                temp = 0.00f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);
        }

        //Increase the value of the LightSize variable
        private void UpdateLightSize2(float value)
        {

            temp += 0.01f * value;
            if (temp >= 1.5f)
                temp = 1.5f;

            displayFPS.lightSize = temp;
            Shader.SetGlobalFloat("lightsize", temp);
            light.localScale = new Vector3(1.0f + temp, 1.0f + temp, 1.0f + temp);

        }*/



}
