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
        //충돌이 일어나는 순간
    {
        if(collision.gameObject.CompareTag("Ground"))
            //만약 Tag가 Ground인 게임 오브젝트와 충돌하였을 때
        {
            Destroy(this.gameObject);
            //this = Rain 스크립트 자기 자신. 스스로를 파괴하여라.
        }
    }
}
