using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField, Header("�X���b�g���[��")]
    public TextMeshProUGUI[] _textText = null;

    [SerializeField, Header("�X���b�g�X�s�[�h")]
    int _Speed;
     
    int  []_Slotnuber = null;

    void Start()
    {
        Application.targetFrameRate = 60;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % _Speed == 0)
        {
            //if(_Slotnuber ! =7)
            {

            }
        }
    }
}
