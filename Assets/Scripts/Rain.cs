using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
        //�浹�� �Ͼ�� ����
    {
        if(collision.gameObject.CompareTag("Ground"))
            //���� Tag�� Ground�� ���� ������Ʈ�� �浹�Ͽ��� ��
        {
            Destroy(this.gameObject);
            //this = Rain ��ũ��Ʈ �ڱ� �ڽ�. �����θ� �ı��Ͽ���.
        }
    }
}
