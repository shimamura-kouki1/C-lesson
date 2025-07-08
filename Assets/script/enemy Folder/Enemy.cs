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
        //���������������搶�ɕ��� 
        //time.time�̓Q�[���J�n����v�Z����Ă����Ɖ��Z����Ă������瑫�����l���傫���Ȃ�
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
