using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear : MonoBehaviour
{
    public Enemy[] enemy;
    /*[]これが配列　
       Enemyのタグをいっぺんにenemyに入れることができ、同時に処理することができる*/
    public GameObject GmaeOverUI;
    public GameObject GmaeClearUI;

    private bool isgameclear=false;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == ("wall"))
          //  Debug.Log("wall");
    }
    // Update is called once per frame
    void Update()
    {
        if (isgameclear !=true)
        {
            if (DestroyAllEnemy())
            {
                //ゲームクリア
                Debug.Log("ゲームクリア");
                //SetActive＝表示、非表示を変更することができる
                GmaeClearUI.SetActive(true);
                isgameclear = true;
            }
        }
    }
    private bool DestroyAllEnemy()
    {
        foreach (Enemy e in enemy)
        {   //eがnullじゃないとき（残っているときに）に｛｝を処理する
            if ( e != null)
            { 
                return false;
            }
        }
        return true;
    }

    public void GameOver() 
    {
        Debug.Log("ゲームオーバー");
        //SetActive＝表示、非表示を変更することができる
        GmaeOverUI.SetActive(true);
    }
    public void GmaeRetry() 
    {//()のなかを再読み込みする。
        SceneManager.LoadScene("game1");

        Time.timeScale = 1;
    }
}
/*変数＝箱　メソッド＝やることリスト　updetoなどのpublicの後の奴や()中の奴と
黄色の文字の奴が*/