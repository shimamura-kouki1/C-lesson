using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//1.スクリプトで親子関係を設定する
public class class1015 : MonoBehaviour
{
    [SerializeField]Vector3 _moveposition;
    [SerializeField]Vector3 _stratPosition;
    [SerializeField]private Transform _parent;
    [SerializeField]private Transform _child;

    [SerializeField] private float _time;

    //問４
    [SerializeField]private TextMeshProUGUI _textMeshPro;
    

    private float _stratTime = 0f;
    private Transform _tr;

    //問4
    private float _clickCount;
    private float _limitTime = 1f;
    private float _timeStrat;
    [SerializeField]private float _clickTotal;
    private bool _timeActive = false;

    //問5
    private BoxCollider _boxCollider;
    private MeshRenderer _meshRenderer;
    private Rigidbody _rb;
    private Material _material;
    // Start is called before the first frame update
    void Start()
    {
        _tr = GetComponent<Transform>();
        _boxCollider = GetComponent<BoxCollider>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();
        _material = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            _child.SetParent(_parent);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            _child.SetParent(null);
        }
        _stratTime += Time.deltaTime;

        transform.position = Vector3.Lerp(_stratPosition, _moveposition, _stratTime / _time);


        //=========================問４======================



        Debug.Log(_timeStrat);
        if (Input.GetMouseButtonDown(0))
        {
            _timeActive = true;
            _clickCount++;
        }

        if (_timeActive == true)
        {
            _timeStrat += Time.deltaTime;
        }

        if (_timeStrat <= _limitTime && _clickCount > _clickTotal)
        {
                _textMeshPro.SetText("5push");
        }
        if (_timeStrat > _limitTime)
        {
            _clickCount = 0;
            _timeStrat = 0f;
        }
    }
}
