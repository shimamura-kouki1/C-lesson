using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slotmain : MonoBehaviour
{

    [SerializeField, Header("スロットリール")]
    public TextMeshProUGUI _leftReel;
    [SerializeField, Header("スロットリール")]
    public TextMeshProUGUI _midReel;
    [SerializeField, Header("スロットリール")]
    public TextMeshProUGUI _rightReel;

    float countTime = 0;

    [SerializeField, Range(0, 100), Header("SlotSpeed")]
    public int _speed;

    private int step = 0;

    //TextMeshProUGUI[] t = null;

    //保存変数とは
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount% _speed == 0)

        countTime += _speed * Time.deltaTime;
        _leftReel.text = countTime.ToString("F0");
        _midReel.text = countTime.ToString("F0");
        _rightReel.text = countTime.ToString("F0");

        if (countTime > 9)
        {
            countTime = 0;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            step++;
        }
    }
}
