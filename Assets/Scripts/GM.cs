using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{


    public int click = 0;
    
    public GameObject buttonKeyGet;
    public GameObject buttonHammerGet;
    public GameObject key;
    public GameObject hammer;
    public GameObject moonGet;
    public GameObject pyokoGet;
    public GameObject kuma;
   [SerializeField] GameObject buttonCrater;

    public Talk talk_;
    public Utujin utujin;
    public Wall wall;

   
    public bool utyujinFlg = false;
    
    public bool keyFlg = false;
    public bool hammerFlg = false;

    public bool hakoFlg = false;

    public bool moonFlg = false;
    public bool pyokoFlg = false;
    public bool edFlg = false;
    

    [SerializeField] AudioClip sound = null;
    [SerializeField] AudioClip sound2 = null;
    AudioSource audioSource = null;

    BGM bgm_;

    
    void Start()
    {
        buttonCrater.SetActive(false);
    }



    public void PushButtonKeyGet()
    {
        buttonKeyGet.SetActive(false);
    }

    public void PushButtonHammerGet()
    {
        buttonHammerGet.SetActive(false);
    }

    public void PushButtonMoonGet()
    {
        moonGet.SetActive(false);

        if (keyFlg && hammerFlg)
        {
            SceneManager.LoadScene("Epilogue B");
        }
    }
    public void PushButtonPyokoGet()
    {
        pyokoGet.SetActive(false);

        if (keyFlg && hammerFlg)
        {
            SceneManager.LoadScene("Epilogue A");
        }
    }
    

    public void PushPyoko()
    {
        if (hammerFlg && !moonFlg)
        {
            pyokoGet.SetActive(true);
            pyokoFlg = true;
        }
    }

    public void PushCrater()
    {
        if (hammerFlg && !pyokoFlg)
        {
            moonGet.SetActive(true);
            moonFlg = true;
        }
    }





    public void PushButtonRocket()
    {
        talk_.Comment(Talk.Character.Rocket);
    }

    public void PushButtonHako()
    {
        if (keyFlg && !hakoFlg)
        {
            buttonHammerGet.SetActive(true);
            hammer.SetActive(true);
            talk_.DisplayMessage("ｶﾁｬ");
            hammerFlg = true;
            hakoFlg = true;
            kuma.SetActive(false);
            buttonCrater.SetActive(true);

            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound);
        }
        if (!hakoFlg)
        {
            talk_.DisplayMessage("カギがかかっている。");
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);
        }

        if (hakoFlg)
        {
            return;
        }
    }




    public void PushButtonkuma()
    {
        talk_.Comment(Talk.Character.Kuma);
    }

    public void PushButtonInu()
    {
        talk_.Comment(Talk.Character.Inu);
    }

    public void PushButtonTikyu()
    {
        talk_.DisplayMessage("地球だ");
    }




    public void PushButtonUtyujin()
    {
       
        
        if (!utyujinFlg)
        {
            talk_.Comment(Talk.Character.Utyujin1, false);
            
        } else
        {
            talk_.Comment(Talk.Character.Utyujin2, false);
        }

        if (talk_.utyujinCnt == 5 && !utyujinFlg)
        {
            wall.wallNo = Wall.UTYUJIN;
            talk_.buttonMessage.SetActive(false);
            talk_.utyujinCnt = 0;
        }

        if (talk_.utyujinCnt == 4 && utyujinFlg)
        {
            keyFlg = true;
            buttonKeyGet.SetActive(true);
            key.SetActive(true);
        }
        

    }


    public void PushButtonUtyujin2()
    {
        if (utujin.IsAnimate == true)
        {
            return;
        }

        click = click + 1;

        if (click == 10)
        {
            //Debug.Log("StartGueAnimation1");
            talk_.DisplayMessage("ぐぇ");

            
            utujin.StartGueAnimation();

            
        }

        if (click == 11)　　　　//click >= 11
        {
            utyujinFlg = true;
            wall.wallNo = Wall.WALL_LEFT;
            talk_.buttonMessage.SetActive(false);
        }

    }
    

}
