using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kagi : MonoBehaviour
{
    System.Action anim_finish_callback_ = null;

    public void SetUp(System.Action callback)
    {
        anim_finish_callback_ = callback;
        gameObject.SetActive(false);
    }

    public void AnimationFinish()
    {
        if (anim_finish_callback_ != null)
        {
            anim_finish_callback_();
        }
    }
}
