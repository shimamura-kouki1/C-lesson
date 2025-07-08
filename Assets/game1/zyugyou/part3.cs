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

    private float _Speed = 1.0f;//変数宣言

    int _kaisuu = 1;//整数リテラル


    char _class = 'B'; //文字リテラル     それ自体が独立していて単独で呼び出される処理

    Rigidbody _rb;

    int Move2 = 1;

    // Start is called before the first frame update
    void Start()
    {　//課題2
        Debug.Log("第六回授業" + _kaisuu + "課題" + "クラス" + _class);//   戻り値：関数とかから出てくる値   引数：関数とかに入れる値

        var _kadai = 1;     //課題1   int = varと推測している　　課題9　宣言をせずに推測して処理してくれる。また、ローカル変数の中でしか使うことができない
        Debug.Log(_kadai + "課題");

        _rb = GetComponent<Rigidbody>();//メンバー変数


        //課題12
        string hello = "こんにちは";

        int i = int.Parse(hello); //文字列をint型に変換することができる　例えば文字列のデータを持ってきてもint型に変えることで計算できたりする

        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        /* var pos = transform.position;

         pos.x = Mathf.Clamp(pos.x,maxX,minX);//課題10

         transform.position = pos;
        */

        Move();
        
    }

    public void Move() //メッソド使用 Move= 関数
    {
        if (Input.GetKey(KeyCode.RightArrow)) //RightArrowが引数
        {
            Vector2 pos = transform.position;
            pos.x += _Speed;
            //pos.x = Mathf.Clamp(pos.x, minX, maxX);
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 pos = transform.position;　// Vector2 にとって transform.positionが戻り値
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




    /*public void Hiki(int Move2) //()の中が引数
    {
        Vector2 pos = transform.position; // Vector2 にとって transform.positionが戻り値
        pos.x -= Move2;　
        transform.position = pos;
    }*/

    const int A = 7;  //定数とはconstとは外部から変化を受けつかない。
            const int B = 72;
            int kadai6(int A, int B)
            {
                return A + B;

            }

            //mathf.clamp() 引数の中の範囲で制限をつけることができる。引数は制限したい値、範囲の下限、範囲の上限に指定する。　戻り値は、valueをminとmaxの間に丸めた値


        
    
}
