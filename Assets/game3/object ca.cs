using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectca : MonoBehaviour
{
    [SerializeField] private GameObject _SquarePrefab;
    [SerializeField] private float _interval;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, new Vector3(1.0f, 2.0f, 1.0f), Quaternion.identity);

        InvokeRepeating("SquareIns", 0f, _interval);
        // for (int i = 0; i < 10; i++)
        //{
        //    Instantiate(enemy, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        // }
    }
    private void SquareIns()
    {
        Instantiate(_SquarePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
