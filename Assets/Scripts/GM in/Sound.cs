using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    [SerializeField] AudioClip pyoko = null;
    [SerializeField] AudioClip isi = null;

    AudioSource audioSource = null;

    GM ge;

    public void PushKuma ()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.volume = 0.13f;
        audioSource.PlayOneShot(pyoko);
    }

    public void PushCrater()
    {
            audioSource = GetComponent<AudioSource>();

            audioSource.PlayOneShot(isi);
    }
}
