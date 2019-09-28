using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{

    public enum Character
    {
        Rocket,
        Kuma,
        Inu,
        Utyujin1,
        Utyujin2
    }

    // Dictionary<>
    public Dictionary<Character, List<string>> messageDic = new Dictionary<Character, List<string>>();

    public int utyujinCnt = 0;
    
    public GameObject buttonMessage;
    public GameObject buttonMessageText;



    void Start()
    {

        
        messageDic[Character.Rocket] = new List<string> { "獣と初めて旅行したかも？", "なんでもいいから持って帰りたいな？", "Z〇Z〇？" };
        messageDic[Character.Kuma] = new List<string> { "トイレ行きたい。。。", "宇宙人って日本語喋るんだ。。。", "熊なのに日本語喋るんだって思ってるでしょ。。。" };
        messageDic[Character.Inu] = new List<string> { "ﾜﾝ", "やった！左手が勝った！", "熊はなんかいいもの持ってるらしい！", "また来週～！" };
        messageDic[Character.Utyujin1] = new List<string> { "あ！地球人さんだ！", "こんにちわ～", "大変申し訳ないのですが、何か喉につまらせたようで", "背中を叩いていただけませんか？", "" };
        messageDic[Character.Utyujin2] = new List<string> { "あ！鍵さんだ！", "こんにちわ～", "いつの間にか食べちゃってたみたいですね", "それは好きに使っていただいて構いませんよ" };

    }

    public void Comment(Character a, bool randam = true)
    {
        List<string> comment = messageDic[a];
        
        int b;

        if (randam == true)
        {
            b = Random.Range(0, comment.Count);
        } else
        {
            b = utyujinCnt;
            utyujinCnt++;
        }
        
        DisplayMessage(comment[b]);
    }

    public void DisplayMessage(string mes)
    {
        buttonMessage.SetActive(true);
        buttonMessageText.GetComponent<Text>().text = mes;
    }


    public void PushButtonMessage()
    {
        buttonMessage.SetActive(false);
    }

}