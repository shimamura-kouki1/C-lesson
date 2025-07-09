using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testS : MonoBehaviour
{
    [SerializeField] private GameObject[] _CubePrefab;
    [SerializeField] private int _sizeX;
    [SerializeField] private int _sizeY;
    [SerializeField] private float _spacing;
    [SerializeField] private float _scale;
    [SerializeField] private float _minsaize;

    private List<Transform> gridObjects = new List<Transform>();
    private int index = 0;
    private bool shrinking = true;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        for (int x = 0; x < _sizeX; x++)
        {
            for (int y = 0; y < _sizeY; y++)
            {

                int color = (x + y ) % _CubePrefab.Length;//色を自動で分ける　i+j+kを色の数で余り算を行う
                GameObject obj = Instantiate(_CubePrefab[color], new Vector3(x,y), Quaternion.identity);//colorでキューブの色を変更する
                obj.transform.localScale = new Vector3(1,1,1);
                gridObjects.Add(obj.transform);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0f && Time.frameCount % 5 == 0)
        {
            
            if (shrinking)
            {
               
                if (index < gridObjects.Count)
                {
                    gridObjects[index].localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    index++;
                }
                else
                {
                    shrinking = false;
                    index = gridObjects.Count - 1;
                }
            }
            else
            {
                if (index >= 0)
                {
                    gridObjects[index].localScale = new Vector3(1,1,1);
                    index--;
                }
                else
                {
                    shrinking = true;
                    index = 0;
                }
            }
        }

    }
}
