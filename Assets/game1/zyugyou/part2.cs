using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;


//using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class part2 : MonoBehaviour
{
    [SerializeField, Range(3.0f, 100.0f), Header("スピード")]
    private float _MoveSpeed;

    Rigidbody _rig;

    private float _WaitForSecond;
    
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("a", 10);

        /*StartCoroutine(b());
        Debug.Log("1");
        Debug.Log("2");
        Debug.Log("3");*/

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(b());
    }

    private void a()
    {
        Debug.Log("aaa");
    }
   
    IEnumerator b()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("bbb");
        }
    }

    /*static async Task Main()
    {
        Debug.Log("処理開始");
        await ProcessDataAsync();
        Debug.Log("処理終了");
    }

    static async Task ProcessDataAsync()
    {
        await Task.Delay(3000); // 3秒待機
        Debug.Log("処理完了2");
    }*/

    /*async Task LoadDataAsync()
    {
        Debug.Log("a");
        await Task.Delay(2000); // 2秒待機
        Debug.Log("b");
    }*/

}



