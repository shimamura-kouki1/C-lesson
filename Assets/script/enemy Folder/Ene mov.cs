//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Enemov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//Rigidbodyを付与
        Rigidbody body = GetComponent<Rigidbody>();
//fpsを30に制限
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        //z軸に1フレーム-0.5ずつ移動
        //transform.position += new Vector3(0, 0, (Time.deltaTime) - 0.5f);

        transform.position += new Vector3(Mathf.Sin(Time.deltaTime) /100,0,0);
    }
    private void OnCollisionEnter(Collision collision)
   {
//接触したときにオブジェクトが破壊される
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
