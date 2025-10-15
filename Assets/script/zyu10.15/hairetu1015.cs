using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu1015 : MonoBehaviour
{
    [SerializeField] private int _cubeCount;
    [SerializeField] private float _generationTime;
    [SerializeField] private GameObject[] _gameObject;

    private int _color;

    void Start()
    {
        StartCoroutine(CubCreate());
    }

    
    IEnumerator CubCreate()
    {
        for (int z = 0; z < _cubeCount; z++)
        {
            for (int x = 0; x < _cubeCount; x++) 
            {
                for (int y = 0; y < _cubeCount; y++) //奥行き
                {
                    if (z == 0 || x == 0 || z == _cubeCount - 1 || x == _cubeCount - 1 || y == 0)
                    {
                    _color = (z + x + y) % _gameObject.Length;//色を自動で分ける　i+j+kを色の数で余り算を行う
                    Instantiate(_gameObject[_color], new Vector3(x, y, -z), Quaternion.identity);//colorでキューブの色を変更する
                    yield return new WaitForSeconds(_generationTime);//指定時間止める
                    }
                }
            }
        }
    }
}
