using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpilogueB : MonoBehaviour {

    public Animator endingB;
    public bool isEnding = false;


    void Start () {
        endingB = GetComponent<Animator>();
        isEnding = true;
        endingB.SetBool("endingB", true);
    }


    public void AnimationFinish()
    {
        isEnding = false;

        if (!isEnding)
        {
            SceneManager.LoadScene("Ending B");
        }

    }

}
