/*
This script is used to implement VR interaction(set the light strength to a low value using the controller button).
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationChange : MonoBehaviour
{
    public int flag = 0;
    public DisplayHint hint;
    public Animator[] animators;

    private void Awake()
    {
        AnimationOn();

    }




    public void ToggleByMenu()
    {

        flag++;
        if (flag == 2)
        {
            flag = 0;
        }

        if (flag == 0)
        {
            AnimationOn();
        }
        else if (flag == 1)
        {
            AnimationOff();
        }

        hint.Show("Animation Change");
    }

    public void AnimationOn()
    {
        foreach (Animator anim in animators)
        {
            anim.enabled = true;
        }

    }

    public void AnimationOff()
    {
        foreach (Animator anim in animators)
        {
            anim.enabled = false;
        }

    }
}
