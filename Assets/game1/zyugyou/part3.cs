using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class part3 : MonoBehaviour
{
    [SerializeField]
    float minX = 0;
    [SerializeField]
    float maxX = 10;

    private float _Speed = 1.0f;//�ϐ��錾

    int _kaisuu = 1;//�������e����


    char _class = 'B'; //�������e����     ���ꎩ�̂��Ɨ����Ă��ĒP�ƂŌĂяo����鏈��

    Rigidbody _rb;

    int Move2 = 1;

    // Start is called before the first frame update
    void Start()
    {�@//�ۑ�2
        Debug.Log("��Z�����" + _kaisuu + "�ۑ�" + "�N���X" + _class);//   �߂�l�F�֐��Ƃ�����o�Ă���l   �����F�֐��Ƃ��ɓ����l

        var _kadai = 1;     //�ۑ�1   int = var�Ɛ������Ă���@�@�ۑ�9�@�錾�������ɐ������ď������Ă����B�܂��A���[�J���ϐ��̒��ł����g�����Ƃ��ł��Ȃ�
        Debug.Log(_kadai + "�ۑ�");

        _rb = GetComponent<Rigidbody>();//�����o�[�ϐ�


        //�ۑ�12
        string hello = "����ɂ���";

        int i = int.Parse(hello); //�������int�^�ɕϊ����邱�Ƃ��ł���@�Ⴆ�Ε�����̃f�[�^�������Ă��Ă�int�^�ɕς��邱�ƂŌv�Z�ł����肷��

        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        /* var pos = transform.position;

         pos.x = Mathf.Clamp(pos.x,maxX,minX);//�ۑ�10

         transform.position = pos;
        */

        Move();
        
    }

    public void Move() //���b�\�h�g�p Move= �֐�
    {
        if (Input.GetKey(KeyCode.RightArrow)) //RightArrow������
        {
            Vector2 pos = transform.position;
            pos.x += _Speed;
            //pos.x = Mathf.Clamp(pos.x, minX, maxX);
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 pos = transform.position;�@// Vector2 �ɂƂ��� transform.position���߂�l
            pos.x -= _Speed;
            //pos.x = Mathf.Clamp(pos.x, minX, maxX);
            transform.position = pos;
        }
    }

    public float Cla(float posx, float minX, float maxX)
    {
        if (posx < minX)
        {
            return minX;
        }
        else if (posx > maxX)
        {
            return maxX;
        }
        else
        {
            return posx;
        }
    }




    /*public void Hiki(int Move2) //()�̒�������
    {
        Vector2 pos = transform.position; // Vector2 �ɂƂ��� transform.position���߂�l
        pos.x -= Move2;�@
        transform.position = pos;
    }*/

    const int A = 7;  //�萔�Ƃ�const�Ƃ͊O������ω����󂯂��Ȃ��B
            const int B = 72;
            int kadai6(int A, int B)
            {
                return A + B;

            }

            //mathf.clamp() �����̒��͈̔͂Ő��������邱�Ƃ��ł���B�����͐����������l�A�͈͂̉����A�͈͂̏���Ɏw�肷��B�@�߂�l�́Avalue��min��max�̊ԂɊۂ߂��l


        
    
}
