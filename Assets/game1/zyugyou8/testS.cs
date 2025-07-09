using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testS : MonoBehaviour
{
    [SerializeField] private GameObject[] _CubePrefab;
    [SerializeField] private int _saize;
    [SerializeField] private float _spacing;
    [SerializeField] private float _scale;
    [SerializeField] private float _minsaize;

    private int index = 0;
    private bool shrinking = true;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        for (int x = 0; x < _saize; x++)
        {
            for (int y = 0; y < _saize; y++)
            {
                int color = (x + y ) % _CubePrefab.Length;//色を自動で分ける　i+j+kを色の数で余り算を行う
                Instantiate(_CubePrefab[color], new Vector3(x,y), Quaternion.identity);//colorでキューブの色を変更する

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 60 == 0)
        {
            if (shrinking)
            {
                _CubePrefab[index].localScale =new Vector3(0.5f,0.5f,0.5f);
                index++;
            }
        }
    }
}
