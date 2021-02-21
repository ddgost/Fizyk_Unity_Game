using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    private Animator anim;

    public string animName;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (LightsButton.isLightOn && ButtonTrigger.inPlace)
        {
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
    }
}
