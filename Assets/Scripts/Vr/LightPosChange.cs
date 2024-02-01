/*
This script is used to implement VR interaction(set the light positon using the controller button).
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightPosChange : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    int flag = 0;
    public Transform light;
    public DisplayHint hint;

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

        //Shader.SetGlobalFloat("_gLightStrength", 50f);
        flag++;
        if(flag == 3)
        {
            flag = 0;
        }

        if(flag == 0) 
        {
            //light.position = new Vector3(0.800000012f, 21.1499996f, -4.03999996f);
            light.position = new Vector3(0.800000012f, 18.11999989f, 11.3500004f);
        }
        else if(flag == 1)
        {
            light.position = new Vector3(0.800000012f, 8.11999989f, -4.03999996f);
        }
        else if(flag == 2)
        {
            light.position = new Vector3(0.800000012f, 18.11999989f, 4.03999996f);
        }
        hint.Show("Light Position Change");
    }

    public void ToggleByMenu()
    {
        //Shader.SetGlobalFloat("_gLightStrength", 50f);
        flag++;
        if (flag == 3)
        {
            flag = 0;
        }

        if (flag == 0)
        {
            //light.position = new Vector3(0.800000012f, 21.1499996f, -4.03999996f);
            light.position = new Vector3(0.800000012f, 18.11999989f, 11.3500004f);
        }
        else if (flag == 1)
        {
            light.position = new Vector3(0.800000012f, 8.11999989f, -4.03999996f);
        }
        else if (flag == 2)
        {
            light.position = new Vector3(0.800000012f, 18.11999989f, 4.03999996f);
        }
        hint.Show("Light Position Change");
    }

}