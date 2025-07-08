using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();

        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 0.5f);

        transform.position+= new Vector3(Mathf.Sin(Time.time) * -0.2f, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
