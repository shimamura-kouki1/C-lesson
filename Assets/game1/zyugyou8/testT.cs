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
            if(i % (_BoxRange * 2) < _BoxRange)     //BoxRangeの二倍を余り算することで余りがBoxRange以内だったら偶数列、以上だったら奇数列にして、
                                                    //BoxLineを二つに割っている
            {                                       //つまりBoxRange=3だった場合、i % 6をすると1～3は偶数列になり4～6が奇数列になる

                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,i % ( _BoxRange * 2),0), Quaternion.identity));

                //_Box[i % _Box.Count]はBoxのListから順番に取り出している。i % Box.Countは余り算で出た数字が取り出すリストのナンバーになっている
                //i / BoxRangeによってBoxRangeで除算式をすることで、その解がXの列になっている。
            }
            else
            {
                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,_BoxRange -1 - ( i % _BoxRange), 0), Quaternion.identity));
                //BoxRangeから「-1」と「 i % _BoxRange」を引くことでY座標が上から下に出るようになっている
            }
        }
    }


    /* void Start()
     {
         Application.targetFrameRate = 60;

         for (int i = 0; i < _BoxLine * _BoxRange; i++)
         {

      int col = i / _BoxRange;  // X座標（列）
     int row = i % _BoxRange;  // Yインデックス

             if (i % (_BoxRange * 2) < _BoxRange)     //BoxRangeの二倍を余り算することで余りがBoxRange以内だったら偶数列、
    　　　　　　　　　　　　　　　　　　　　　　　　　　以上だったら奇数列にして、BoxLineを二つに割っている
             {                                       //つまりBoxRange=3だった場合、i % 6をすると1～3は偶数列になり4～6が奇数列になる

                 _gridObjects.Add(Instantiate(col * _spacing, row * _spacing, 0), Quaternion.identity));

                 //_Box[i % _Box.Count]はBoxのListから順番に取り出している。i % Box.Countは余り算で出た数字が取り出すリストのナンバーになっている
                 //i / BoxRangeによってBoxRangeで除算式をすることで、その解がXの列になっている。
                 //
             }
             else
             {
                 _gridObjects.Add(Instantiate(_Box[i % _Box.Count], new Vector3((col * _spacing, (_BoxRange - 1 - row) * _spacing, 0), Quaternion.identity));
                 //BoxRangeから「-1」と「 i % _BoxRange」を引くことでY座標が上から下に出るようになっている
             }
         }
     }*/

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % _Speed == 0)
        {
            if (_NowCount != _BoxLine * _BoxRange && _NowCount != -1)
            {
                if (_gridObjects[_NowCount].transform.localScale != Vector3.one * 0.5f)

                //_gridObjects[_NowCount]は_gridObjectsの_NowCount番目のobjectを取り出している
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one * 0.5f;
                    //サイズを0.5にする
                }
                else
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one;
                    //サイズを等倍にする
                }
            }

            if(_countReset % 2 == 0) //_countResetが偶数だったらカウントをプラスしていく
            {
                _NowCount++;
            }
            else
            {
                _NowCount--;
            }

            if(_NowCount == _BoxLine * _BoxRange || _NowCount == -1) //_NowCountがオブジェクトの総数と同じになる。
                                                                     //もしくは、_NowCountが-1になったらCountResetを増やす
            {
                _countReset++;
            }
        }
    }
}
