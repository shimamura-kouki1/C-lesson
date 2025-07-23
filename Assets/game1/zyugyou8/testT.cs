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
            if(i % (_BoxRange * 2) < _BoxRange)     //BoxRange�̓�{��]��Z���邱�Ƃŗ]�肪BoxRange�ȓ��������������A�ȏゾ��������ɂ��āA
                                                    //BoxLine���Ɋ����Ă���
            {                                       //�܂�BoxRange=3�������ꍇ�Ai % 6�������1�`3�͋�����ɂȂ�4�`6�����ɂȂ�

                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,i % ( _BoxRange * 2),0), Quaternion.identity));

                //_Box[i % _Box.Count]��Box��List���珇�ԂɎ��o���Ă���Bi % Box.Count�͗]��Z�ŏo�����������o�����X�g�̃i���o�[�ɂȂ��Ă���
                //i / BoxRange�ɂ����BoxRange�ŏ��Z�������邱�ƂŁA���̉���X�̗�ɂȂ��Ă���B
            }
            else
            {
                _gridObjects.Add(Instantiate(_Box[i % _Box.Count],new Vector3(i / _BoxRange,_BoxRange -1 - ( i % _BoxRange), 0), Quaternion.identity));
                //BoxRange����u-1�v�Ɓu i % _BoxRange�v���������Ƃ�Y���W���ォ�牺�ɏo��悤�ɂȂ��Ă���
            }
        }
    }


    /* void Start()
     {
         Application.targetFrameRate = 60;

         for (int i = 0; i < _BoxLine * _BoxRange; i++)
         {

      int col = i / _BoxRange;  // X���W�i��j
     int row = i % _BoxRange;  // Y�C���f�b�N�X

             if (i % (_BoxRange * 2) < _BoxRange)     //BoxRange�̓�{��]��Z���邱�Ƃŗ]�肪BoxRange�ȓ��������������A
    �@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�ȏゾ��������ɂ��āABoxLine���Ɋ����Ă���
             {                                       //�܂�BoxRange=3�������ꍇ�Ai % 6�������1�`3�͋�����ɂȂ�4�`6�����ɂȂ�

                 _gridObjects.Add(Instantiate(col * _spacing, row * _spacing, 0), Quaternion.identity));

                 //_Box[i % _Box.Count]��Box��List���珇�ԂɎ��o���Ă���Bi % Box.Count�͗]��Z�ŏo�����������o�����X�g�̃i���o�[�ɂȂ��Ă���
                 //i / BoxRange�ɂ����BoxRange�ŏ��Z�������邱�ƂŁA���̉���X�̗�ɂȂ��Ă���B
                 //
             }
             else
             {
                 _gridObjects.Add(Instantiate(_Box[i % _Box.Count], new Vector3((col * _spacing, (_BoxRange - 1 - row) * _spacing, 0), Quaternion.identity));
                 //BoxRange����u-1�v�Ɓu i % _BoxRange�v���������Ƃ�Y���W���ォ�牺�ɏo��悤�ɂȂ��Ă���
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

                //_gridObjects[_NowCount]��_gridObjects��_NowCount�Ԗڂ�object�����o���Ă���
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one * 0.5f;
                    //�T�C�Y��0.5�ɂ���
                }
                else
                {
                    _gridObjects[_NowCount].transform.localScale = Vector3.one;
                    //�T�C�Y�𓙔{�ɂ���
                }
            }

            if(_countReset % 2 == 0) //_countReset��������������J�E���g���v���X���Ă���
            {
                _NowCount++;
            }
            else
            {
                _NowCount--;
            }

            if(_NowCount == _BoxLine * _BoxRange || _NowCount == -1) //_NowCount���I�u�W�F�N�g�̑����Ɠ����ɂȂ�B
                                                                     //�������́A_NowCount��-1�ɂȂ�����CountReset�𑝂₷
            {
                _countReset++;
            }
        }
    }
}
