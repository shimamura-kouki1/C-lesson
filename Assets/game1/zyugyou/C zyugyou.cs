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
    void Update()//update =�t���[���Ɉ��

    {/*Time.frameCount=��b�̃t���[�����J�E���g
        60�Ŋ����ĂO�ɂȂ�������s*/
        //if (Time.frameCount % 60 == 0)
        //{
        //    Debug.Log("60�t���[��");
        //}


        /*for(�������A�����A����)
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("60�t���[��");
        }*/

        /*Time.frameCount = ��b�̃t���[�����J�E���g
        60�Ŋ����ĂO�ɂȂ�������s */



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
        /*�Q�S���Ԏ��vif(Time.frameCount % 60 == 0)
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
            Debug.Log(CountC + "����" + CountB + "��" + CountA + "�b");*/


        {
            DateTime now = DateTime.Now;
            Debug.Log("���݂̎���: " + now.ToString("HH:mm:ss"));
        }



        //if (Time.frameCount % 3600 == 0)
        //{
        //    Debug.Log("��");
        //}

        //if(Time.frameCount % 21600 == 0)  
        //{
        //    Debug.Log("����");
        //}

        //Debug.Break();�ꎞ��~�ł���

        /*for (int se = 0; se < 60; se++)
        {

        }*/

        //if�͓��ނ܂ŁAswich�͎O��ވȏ�ł���
    }
}
