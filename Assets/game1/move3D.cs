using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3D : MonoBehaviour
{
    public Rigidbody _rb = null;
    public Transform _tr = null;
    //fristjump‚ÉboolŠÖ”‚ğtrue‚Åg—p‚·‚é
    private bool firstjump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _tr = GetComponent<Transform>();
        //firstjump‚Étrue‚ğ‘ã“ü‚·‚é
        firstjump = true;
        
        Application.targetFrameRate = 60;
    }

    void OnCollisionEnter(Collision collision)
    {//‚à‚µground‚ÉG‚ê‚Ä‚¢‚½‚ç
        if (collision.gameObject.tag == ("ground"))
        {//fristjump‚ğtrue‚É
            firstjump = true; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { transform.position += new Vector3(0.3f, 0, 0); }

        if (Input.GetKey(KeyCode.S))
        { transform.position += new Vector3(-0.3f, 0, 0); }

        if (Input.GetKey(KeyCode.D))
        { _tr.position += new Vector3(0, 0, -0.3f); }

        if (Input.GetKey(KeyCode.A))
        { _tr.position += new Vector3(0, 0, 0.3f); }

        if (Input.GetKey(KeyCode.Space) && firstjump)
        {//‚à‚µfirstjump‚ªtrue‚Ìê‡
            if (firstjump == true)
            //jump‚Ì‚‚³
            { _rb.velocity = new Vector3(0, 5.5f, 0); }
            //jump‚ğ‚µ‚½‚çfalse‚É•Ï‚¦‚é   
            firstjump = false;}

           // _tr.position += new Vector3(0, 0.5f, 0); }

   @}
}
