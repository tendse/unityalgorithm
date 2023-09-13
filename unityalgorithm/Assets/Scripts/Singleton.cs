using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }     //�̱��� ȣ�� Static < �������� �޸𸮿� �÷���

    private void Awake()                                        //Awake�� ���� �ɶ�
    {
        if (Instance == null)                                    //�ش� �ν��Ͻ��� ������ ������
        {
            Instance = this;                                    //�ν��Ͻ��� �� Ŭ���� -> class Singleton
            DontDestroyOnLoad(gameObject);                      //����Ƽ�� �ı����� �ʴ� ��ü�� ���
        }
        else
        {
            Destroy(gameObject);                                //�ش� �ν��Ͻ��� �����ϸ� �������ڸ��� �ı��ȴ�.
        }
    }
    public int playerScore = 0;                                 //�÷��̾� ���ھ� ���
    public void InscreaseScore(int amount)                      //�Լ��� ���ؼ� ���������ش�. 
    {
        playerScore += amount;
    }
}