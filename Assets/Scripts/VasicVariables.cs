using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;        //������
    public float Hp = 100.0f;   //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f' �ʼ�)
    public string playerName = "ȫ�浿";      //���ڿ� (������ ����)
    private bool isAlive = true;               //���� (��/������ ��Ÿ��) true/false

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("���� ������");       //����Ƽ ����׿� �޼����� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
