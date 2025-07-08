//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class move : MonoBehaviour
{
   // float jumpForce = 8f;
    public Rigidbody _rb = null;

    public Transform _tr = null;
//isJumpingにboolを付与
    public bool isJumping;
    public bool twoJumping;
    public gameclear Gameclear;

    // Start is called before the first frame update
    void Start()
    {
//Rigidbodyの付与
        _rb = GetComponent<Rigidbody>();
//ジャンプをしてない時はfalseを付与
        isJumping = false;
        twoJumping = false;
//fpsの最大値30に固定
        Application.targetFrameRate = 30;
//transformを_trで読み込めるようにする
        _tr = transform;
    }

    // Update is called once per frame
    void Update()
    {　 
//Wを押しているとき
        if (Input.GetKey(KeyCode.W))
//前方へ0.05進
        {_tr.position += new Vector3(0, 0, 0.25f);
        }
//A押しているとき
        if (Input.GetKey(KeyCode.A))
        {
//左に進
            _tr.position += new Vector3(-0.3f, 0, 0);
        }
//Dを押している時
        if (Input.GetKey(KeyCode.D))
        {
//右に進む
            _tr.position += new Vector3(0.3f, 0, 0);
        }
//Sキーを押しているとき
        if (Input.GetKey(KeyCode.S))
        {
//後ろへ0.05下がる
            _tr.position += new Vector3(0, 0, -0.3f);
        }
//Qキーの入力をしたら
        if (Input.GetKey(KeyCode.Q))
        {　
//座標(0,1,0)にポジションリセット
            _tr.position = new Vector3(0, 1, 0);
        }

//スペースを入力したら
        if (Input.GetKey(KeyCode.Space))
        {　 
//もしfalseだったらjump可能　
            if (isJumping == false)
            {
//Jumpの高さ
                _rb.velocity = new Vector3(0, 5.5f, 0);

            }
//Jumpをしたらtrueになる
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isJumping && !twoJumping)
            twoJumping = true;
        
        {
            // _rb.velocity = Vector3.up * jumpForce;
            //velocityについて調べる
        }

    }
    void OnCollisionEnter(Collision Collison)
    {
//もしgroundに触れたら場合
        if (Collison.gameObject.tag == ("ground"))
        {
//falseの場合Jumpを可能にする
            isJumping = false;
        }
        
        
//もしenemyタグのオブジェクトに触れた
        if (Collison.gameObject.tag == ("enemy"))
        {
            Destroy(this.gameObject);
            Gameclear.GameOver();

            Time.timeScale = 0;
        }

    }

    
}