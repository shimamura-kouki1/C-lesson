using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear : MonoBehaviour
{
    public Enemy[] enemy;
    /*[]���ꂪ�z��@
       Enemy�̃^�O�������؂��enemy�ɓ���邱�Ƃ��ł��A�����ɏ������邱�Ƃ��ł���*/
    public GameObject GmaeOverUI;
    public GameObject GmaeClearUI;

    private bool isgameclear=false;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == ("wall"))
          //  Debug.Log("wall");
    }
    // Update is called once per frame
    void Update()
    {
        if (isgameclear !=true)
        {
            if (DestroyAllEnemy())
            {
                //�Q�[���N���A
                Debug.Log("�Q�[���N���A");
                //SetActive���\���A��\����ύX���邱�Ƃ��ł���
                GmaeClearUI.SetActive(true);
                isgameclear = true;
            }
        }
    }
    private bool DestroyAllEnemy()
    {
        foreach (Enemy e in enemy)
        {   //e��null����Ȃ��Ƃ��i�c���Ă���Ƃ��Ɂj�Ɂo�p����������
            if ( e != null)
            { 
                return false;
            }
        }
        return true;
    }

    public void GameOver() 
    {
        Debug.Log("�Q�[���I�[�o�[");
        //SetActive���\���A��\����ύX���邱�Ƃ��ł���
        GmaeOverUI.SetActive(true);
    }
    public void GmaeRetry() 
    {//()�̂Ȃ����ēǂݍ��݂���B
        SceneManager.LoadScene("game1");

        Time.timeScale = 1;
    }
}
/*�ϐ������@���\�b�h����邱�ƃ��X�g�@updeto�Ȃǂ�public�̌�̓z��()���̓z��
���F�̕����̓z��*/