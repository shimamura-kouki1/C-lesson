//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class move : MonoBehaviour
{
   // float jumpForce = 8f;
    public Rigidbody _rb = null;

    public Transform _tr = null;
//isJumping��bool��t�^
    public bool isJumping;
    public bool twoJumping;
    public gameclear Gameclear;

    // Start is called before the first frame update
    void Start()
    {
//Rigidbody�̕t�^
        _rb = GetComponent<Rigidbody>();
//�W�����v�����ĂȂ�����false��t�^
        isJumping = false;
        twoJumping = false;
//fps�̍ő�l30�ɌŒ�
        Application.targetFrameRate = 30;
//transform��_tr�œǂݍ��߂�悤�ɂ���
        _tr = transform;
    }

    // Update is called once per frame
    void Update()
    {�@ 
//W�������Ă���Ƃ�
        if (Input.GetKey(KeyCode.W))
//�O����0.05�i
        {_tr.position += new Vector3(0, 0, 0.25f);
        }
//A�����Ă���Ƃ�
        if (Input.GetKey(KeyCode.A))
        {
//���ɐi
            _tr.position += new Vector3(-0.3f, 0, 0);
        }
//D�������Ă��鎞
        if (Input.GetKey(KeyCode.D))
        {
//�E�ɐi��
            _tr.position += new Vector3(0.3f, 0, 0);
        }
//S�L�[�������Ă���Ƃ�
        if (Input.GetKey(KeyCode.S))
        {
//����0.05������
            _tr.position += new Vector3(0, 0, -0.3f);
        }
//Q�L�[�̓��͂�������
        if (Input.GetKey(KeyCode.Q))
        {�@
//���W(0,1,0)�Ƀ|�W�V�������Z�b�g
            _tr.position = new Vector3(0, 1, 0);
        }

//�X�y�[�X����͂�����
        if (Input.GetKey(KeyCode.Space))
        {�@ 
//����false��������jump�\�@
            if (isJumping == false)
            {
//Jump�̍���
                _rb.velocity = new Vector3(0, 5.5f, 0);

            }
//Jump��������true�ɂȂ�
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isJumping && !twoJumping)
            twoJumping = true;
        
        {
            // _rb.velocity = Vector3.up * jumpForce;
            //velocity�ɂ��Ē��ׂ�
        }

    }
    void OnCollisionEnter(Collision Collison)
    {
//����ground�ɐG�ꂽ��ꍇ
        if (Collison.gameObject.tag == ("ground"))
        {
//false�̏ꍇJump���\�ɂ���
            isJumping = false;
        }
        
        
//����enemy�^�O�̃I�u�W�F�N�g�ɐG�ꂽ
        if (Collison.gameObject.tag == ("enemy"))
        {
            Destroy(this.gameObject);
            Gameclear.GameOver();

            Time.timeScale = 0;
        }

    }

    
}