using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class testT : MonoBehaviour
{
   // [SerializeField] private GameObject[] _CubePrefab;
    [SerializeField] private int _BoxLine;
    [SerializeField] private int _BoxRange;
    [SerializeField] private int _spacing;
    [SerializeField] private int _scale;
    [SerializeField] private int _Speed;

    [SerializeField]
    List<GameObject> _Box;
    int _NowCount = 0;
    int _countReset = 0;
    private List<GameObject> _gridObjects = new ();
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
       
        for (int i = 0;i < _BoxLine * _BoxRange ; i++)
        {
            if(i % (_BoxRange * 2) < _BoxRange)
            {
                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,i % ( _BoxRange * 2),0), Quaternion.identity));
            }
            else
            {
                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,_BoxRange -1 - ( i % _BoxRange), 0), Quaternion.identity));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % _Speed == 0)
        {
            if (_NowCount != _BoxLine * _BoxRange && _NowCount != -1)
            {
                if (_gridObjects[_NowCount].transform.localScale != Vector3.one * 0.5f)
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one * 0.5f;
                }
                else
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one;
                }
            }

            if(_countReset % 2 == 0)
            {
                _NowCount++;
            }
            else
            {
                _NowCount--;
            }

            if(_NowCount == _BoxLine * _BoxRange || _NowCount == -1)
            {
                _countReset++;
            }
        }
    }
}
