//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class wallmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) / 100, 0,0 );
    }
}
