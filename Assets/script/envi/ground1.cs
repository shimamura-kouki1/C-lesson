using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ground1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("ground");
       Debug.Log("Tag=ground");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
