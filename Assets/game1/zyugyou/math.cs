using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class math : MonoBehaviour
{
    Vector3 sphereCenter = new Vector3(0, 0, 0);

    float radius = 5f;
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;

    //bool _Inside = false;

    Vector3 _cubeCenter = Vector3.zero;
    float _cubelength = 6f;


    private float distance_two;
    float _start = 0f;//énì_
    float _end = 10f;//èIì_
    float _time = 0f;
    float _framescurrent = 0f;//à⁄ìÆéûä‘ ÉtÉåÅ[ÉÄ
    int _framesPerSecond = 60;

    
    bool _isjump = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        float distance = Mathf.Sqrt(Mathf.Pow(1 - 5, 2) + Mathf.Pow(3 - 7, 2) + Mathf.Pow(5 - 9, 2));

        Debug.Log(distance);

        
    }

    // Update is called once per frame
    void Update()
    {
        //sphere();
        //Cube();

        //Move();
        Jamp();

        //MoveTime();

    }

    private void sphere()
    {
        Vector3 Point = new Vector3(x, y, z);

        bool _Inside = (Point - sphereCenter).sqrMagnitude <= radius * radius;

        Debug.Log(_Inside);
    }

    private void Cube()
    {
        Vector3 Point = new Vector3(x, y, z);

        float _cubeLengthHalf = _cubelength / 2f;

        bool _InsideCube = (Point.x >= _cubeCenter.x - _cubeLengthHalf) && (Point.x <= _cubeCenter.x + _cubeLengthHalf) &&
                           (Point.y >= _cubeCenter.y - _cubeLengthHalf) && (Point.y <= _cubeCenter.y + _cubeLengthHalf) &&
                           (Point.z >= _cubeCenter.z - _cubeLengthHalf) && (Point.z <= _cubeCenter.z + _cubeLengthHalf);

        Debug.Log(_InsideCube);

    }
    void OnDrawGizmos()
    {
        Gizmos.color = new UnityEngine.Color(1, 0, 0, 0.5f);
        Gizmos.DrawWireCube(transform.position, new Vector3(1,1,1));
    }

    private void Move()
    {
        _framescurrent++;//éûä‘ÇÃâ¡éZ

        float t = Mathf.Clamp01((float)_framescurrent / _framesPerSecond);//éûä‘Ç…ëŒÇ∑ÇÈà⁄ìÆãóó£ÇÃåvéZ

        transform.position = new Vector3(Mathf.Lerp(_start, _end, t), 0, 0);//
        
    }

    private void MoveTime()
    {
        // åoâﬂéûä‘Çâ¡éZ
        _time += Time.deltaTime;

        // 0Å`1 Ç…ê≥ãKâªÅi1ïbÇ©ÇØÇƒ 1 Ç…Ç»ÇÈÅj
        float t = Mathf.Clamp01(_time / 1f);

        // Lerp Ç≈ï‚ä‘
        transform.position = new Vector3(Mathf.Lerp(_start, _end, t), 0, 0);//
    }

    private void Jamp()//ñ‚6
    {

        if (Input.GetKey(KeyCode.Space)&& !_isjump)
        {
            _isjump = true;
            _framescurrent = 0;
        }

        if(_isjump)
        {
            _framescurrent++;//éûä‘ÇÃâ¡éZ

            int _totalframe = _framesPerSecond * 2;
            float t = (float)_framescurrent / _framesPerSecond;
            t = Mathf.Clamp01(t);

            //float t = Mathf.Clamp01((float)_framescurrent / _framesPerSecond);//éûä‘Ç…ëŒÇ∑ÇÈà⁄ìÆãóó£ÇÃåvéZ

            transform.position = new Vector3(0, Mathf.Lerp(_start, _end, t), 0);

            if (_framescurrent == _framesPerSecond)
            {
                float temp =  _end;
                _end = _start;
                _start = temp;
                t = 0f;
            }

            if (_framescurrent >= _totalframe)
            {
                _isjump = false;

                _framescurrent = 0;
            }
        }

    }
}
