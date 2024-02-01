/*
This script is used to implement VR interaction(set the light strength to a low value using the controller button).
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightStrengthChange : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    int flag = 1;
    public DisplayHint hint;

    private void Awake()
    {
        Shader.SetGlobalFloat("_gLightStrength", 50f);

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
            Shader.SetGlobalFloat("_gLightStrength", 100f);
        }
        else if (flag == 1)
        {
            Shader.SetGlobalFloat("_gLightStrength", 50f);
        }
        else if (flag == 2)
        {
            Shader.SetGlobalFloat("_gLightStrength", 25f);
        }
        hint.Show("Light Strength Change");
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
            Shader.SetGlobalFloat("_gLightStrength", 100f);
        }
        else if (flag == 1)
        {
            Shader.SetGlobalFloat("_gLightStrength", 50f);
        }
        else if (flag == 2)
        {
            Shader.SetGlobalFloat("_gLightStrength", 25f);
        }
        hint.Show("Light Strength Change");
    }
}
