using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tseM : MonoBehaviour
{
    [SerializeField] private GameObject[] _CubePrefab;
    [SerializeField] private int _sizeX;
    [SerializeField] private int _sizeY;
    [SerializeField] private float _spacing;
    [SerializeField] private float _scale;
    [SerializeField] private float _minsaize;

    private List<Transform> gridObjects = new List<Transform>();
    //private int index = 0;
    //private bool shrinking = true;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        for (int x = 0; x < _sizeX; x++)
        {
            for (int y = 0; y < _sizeY; y++)
            {
                int color = (x + y) % _CubePrefab.Length;//色を自動で分ける　i+j+kを色の数で余り算を行う
                if (y % (_sizeY * 2)<_sizeY)
                {
                    GameObject obj = Instantiate(_CubePrefab[color], new Vector3(x, y), Quaternion.identity);//colorでキューブの色を変更する
                    obj.transform.localScale = new Vector3(1, 1, 1);
                    gridObjects.Add(obj.transform);
                }
                else
                {
                    GameObject obj = Instantiate(_CubePrefab[color], new Vector3(x - 1, y), Quaternion.identity);//colorでキューブの色を変更する
                    obj.transform.localScale = new Vector3(1, 1, 1);
                    gridObjects.Add(obj.transform);
                }
            }
        }

    }
}
