using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

    [SerializeField] AudioClip bgm = null;
    AudioSource audioSource = null;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(bgm);

        //audioSource.volume = 0.1f;
        //audioSource.loop = true;
    }

    public void Bgm()
    {
        audioSource.Stop();
    }
}
