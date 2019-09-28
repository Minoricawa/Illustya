using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour {

    public Animator prologue;
    public bool isPrologue = false;

    void Start ()
    {
        prologue = GetComponent<Animator>();
        isPrologue = true;
        prologue.SetBool("prologue", true);
    }

    public void AnimationFinish()
    {
        isPrologue = false;

        if (!isPrologue)
        {
            SceneManager.LoadScene("GameScene");
        }
 
    }

}
