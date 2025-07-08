using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Czyugyou : MonoBehaviour
{
    public float time;
    public int CountA = 0;
    public int CountB = 0;
    public int CountC = 0;
    //private int frameCount = 0;
    // Start is called before the first frame update

    void Start()
    {
        Application.targetFrameRate = 60;

        time = 0;
    }

    // Update is called once per frame
    void Update()//update =フレームに一回

    {/*Time.frameCount=一秒のフレームをカウント
        60で割って０になったら実行*/
        //if (Time.frameCount % 60 == 0)
        //{
        //    Debug.Log("60フレーム");
        //}


        /*for(初期化、条件、増減)
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("60フレーム");
        }*/

        /*Time.frameCount = 一秒のフレームをカウント
        60で割って０になったら実行 */



        /*  if (Time.frameCount % 60 == 0)
        {
            CountA = 60;
        }
        if (CountA % 60 == 0)
        {
            CountA = 0;
        }

        if (Time.frameCount % 3600 == 0)
        {
            CountB++;
            //for (int CountA = 0; CountA < 60; CountB++)
        }
        if (CountB == 60 % 60)
        {
            CountB = 0;
        }
        if (Time.frameCount % 21600 == 0)
        {
            CountC++;
        }
        if (CountC == 24)
        {
            CountC = 0;
        }*/


        //
        /*２４時間時計if(Time.frameCount % 60 == 0)
        {
            CountA++;
            if (CountA >= 60)
            {
                CountB++;
                CountA=0;
            }
            if (CountB >= 60)
            {
                CountC++;
                CountB=0;
            }
            if(CountC >= 24)
            {
                CountA = 0;
                CountB = 0;
                CountC = 0;
            }
        }
            Debug.Log(CountC + "時間" + CountB + "分" + CountA + "秒");*/


        {
            DateTime now = DateTime.Now;
            Debug.Log("現在の時間: " + now.ToString("HH:mm:ss"));
        }



        //if (Time.frameCount % 3600 == 0)
        //{
        //    Debug.Log("分");
        //}

        //if(Time.frameCount % 21600 == 0)  
        //{
        //    Debug.Log("時間");
        //}

        //Debug.Break();一時停止できる

        /*for (int se = 0; se < 60; se++)
        {

        }*/

        //ifは二種類まで、swichは三種類以上できる
    }
}
