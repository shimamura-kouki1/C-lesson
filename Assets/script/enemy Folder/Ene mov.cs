//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Enemov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//Rigidbody��t�^
        Rigidbody body = GetComponent<Rigidbody>();
//fps��30�ɐ���
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        //z����1�t���[��-0.5���ړ�
        //transform.position += new Vector3(0, 0, (Time.deltaTime) - 0.5f);

        transform.position += new Vector3(Mathf.Sin(Time.deltaTime) /100,0,0);
    }
    private void OnCollisionEnter(Collision collision)
   {
//�ڐG�����Ƃ��ɃI�u�W�F�N�g���j�󂳂��
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
