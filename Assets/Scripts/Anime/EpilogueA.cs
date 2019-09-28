using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpilogueA : MonoBehaviour {

    public Animator endingA;
    public bool isEnding = false;

    void Start () {
        endingA = GetComponent<Animator>();
        isEnding = true;
        endingA.SetBool("endingA", true);
    }



    public void AnimationFinish()
    {
        isEnding = false;

        if (!isEnding)
        {
            SceneManager.LoadScene("Ending A");
        }

    }

}
