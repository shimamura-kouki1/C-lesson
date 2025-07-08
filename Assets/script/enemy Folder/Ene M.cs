using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
//RigidbodyÇïtó^
        Rigidbody body = GetComponent<Rigidbody>();
//fpsÇ30Ç…êßå¿
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) * 0.2f, 0,0);

        transform.position += new Vector3(0, 0, -0.5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
