//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindWithTag("enemy");
        //Debug.Log("Tag=enemy");

        Rigidbody body = GetComponent<Rigidbody>();

        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        //挙動がおかしい先生に聞く 
        //time.timeはゲーム開始から計算されてずっと加算されていくから足される値が大きくなる
        //transform.position += new Vector3(0, 0, (Time.time)-0.5f);
        transform.position += new Vector3(0, 0, (Time.deltaTime) *- 15);
        //Debug.Log(Time.time);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
