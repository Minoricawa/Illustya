using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utujin : MonoBehaviour {

    bool is_animate_ = false;
    // プロパティ.
    public bool IsAnimate
    {
        get {
            return is_animate_;
        }
    }

    Animator anim;

    [SerializeField] Kagi kagi = null;

    [SerializeField] AudioClip se1 = null;

    AudioSource audioSource = null;


    public GM ge;


    void Start () {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        
        if (kagi != null)
        {
            kagi.SetUp(AnimationFinish);
        }
        

    }
	
    public void StartGueAnimation()
    {
        audioSource.PlayOneShot(se1);

        //Debug.Log("StartGueAnimation2");
        //anim.SetBool("gue", true);

        is_animate_ = true;
        if (kagi != null)
        {
            kagi.gameObject.SetActive(true);
            Animator kagianim = kagi.gameObject.GetComponent<Animator>();
            kagianim.SetBool("start", true);

        }

    }

    public void AnimationFinish()
    {
        is_animate_ = false;
        //ge.utyujinFlg = true;
    }
    
}
