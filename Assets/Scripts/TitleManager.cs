using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    [SerializeField] AudioClip push = null;
    AudioSource audioTitle = null;



    public void PushStartButton()
    {
        audioTitle = GetComponent<AudioSource>();
        audioTitle.PlayOneShot(push);

        StartCoroutine("ToPrologue");
    }

    IEnumerator ToPrologue()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Prologue");
    }

}
