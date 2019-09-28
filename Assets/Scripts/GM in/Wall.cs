using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    
    public int wallNo;

    public const int WALL_FRONT = 1; //前
    public const int WALL_RIGHT = 2; //右
    public const int WALL_BACK = 3; //後ろ
    public const int WALL_LEFT = 4; //左
    public const int UTYUJIN = 5;

    public GameObject panelWalls;

    public Talk talk_;
    public GM ge;


    void Start()
    {
        wallNo = WALL_FRONT;
    }

        public void DisplayWall()
        {
            switch (wallNo)
            {
                case WALL_FRONT:
                    panelWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                    break;

                case WALL_RIGHT:
                    panelWalls.transform.localPosition = new Vector3(-1400.0f, 0.0f, 0.0f);
                    break;

                case WALL_BACK:
                    panelWalls.transform.localPosition = new Vector3(-2800.0f, 0.0f, 0.0f);
                    break;

                case WALL_LEFT:
                    panelWalls.transform.localPosition = new Vector3(-4200.0f, 0.0f, 0.0f);
                    break;

                case UTYUJIN:
                    panelWalls.transform.localPosition = new Vector3(-5600.0f, 0.0f, 0.0f);
                    break;
            }
        }



    public void PushButtonHidari()
    {

        wallNo--;


        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_LEFT;
        }

        DisplayWall();

        talk_.buttonMessage.SetActive(false);
        ge.buttonKeyGet.SetActive(false);
        ge.buttonHammerGet.SetActive(false);

    }

    public void PushButtonMigi()
    {
        wallNo++;

        if (wallNo > WALL_LEFT)
        {
            wallNo = WALL_FRONT;
        }

        DisplayWall();

        talk_.buttonMessage.SetActive(false);
        ge.buttonKeyGet.SetActive(false);
        ge.buttonHammerGet.SetActive(false);

    }

}
