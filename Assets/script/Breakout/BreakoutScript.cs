using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutScript : MonoBehaviour
{
    [SerializeField]
    private float _boolSpeed;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + transform.forward * _boolSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.rotation = Quaternion.LookRotation(Vector3.Reflect(transform.forward, collision.contacts[0].normal),Vector3.up);
    }
}
