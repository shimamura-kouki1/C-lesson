using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Profiling;

public class dai5 : MonoBehaviour
{
    /*[SerializeField, Header("���O")]
    private int _kai;

    [SerializeField, Header("�ړ�")]
    private int _move;

    [SerializeField, Header("��]")]
    private int _rot;

    [SerializeField, Header("�g��")]
    private int _lsc;

    [SerializeField, Header("�ړ�2")]
    private int _pos;*/

    [SerializeField,Header("�ϐ�")]
    private int _un;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* for (int i = 0; i < _kai; i++) 
          {
              Debug.Log("a");
          }



          for (int i = 0; i < _move; i++)
          {
              transform.position += new Vector3(0, 0,500);
          }

          for (int i = 0; i < _rot; i++)
          {
              transform.localRotation = Quaternion.Euler(90, 0,0);
          }

          for (int i = 0; i < _lsc; i++)
          {
              transform.localScale = new Vector3(500,0,0);
          }


          for (int i = 0; i < _pos; i++)
          {
             transform.localPosition = new Vector3(500, 0,0);
          }*/

        int number = _un;

        switch (number)
        {
            case 0:
                for (int i = 0; i < 500; i++)
                {
                    Debug.Log("a");
                }
                break;

            case 1:
                {
                    for (int i = 0; i < 500; i++)
                    {
                        transform.position += new Vector3(0, 0, 500);
                    }
                    break;
                }

            case 2:
                {
                    for (int i = 0; i < 500; i++)
                    {
                        transform.localRotation = Quaternion.Euler(90, 0, 0);
                    }
                    break;
                }

            case 3:
                {
                    for (int i = 0; i < 500; i++)
                    {
                        transform.localScale = new Vector3(500, 0, 0);
                    }
                    break;
                }
            case 4:
                {
                    for (int i = 0; i < 500; i++)
                    {
                        transform.localPosition = new Vector3(500, 0, 0);
                    }
                    break;
                }

        }

        //Profiler.BeginSample("Debug");
        // Profiler.EndSample();
    }
}
