using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;
    // direction 은 0.05f 이다.

    SpriteRenderer renderer;
    //SpriteRenderer를 renderer라고 정의한다.

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //1초에 60프레임으로 고정한다.
        renderer = GetComponent<SpriteRenderer>(); //renderer는 SpriteRender의 기능을 사용한다.
        // Debug.Log("안녕"); //시작하며 안녕이라는 말이 로그에 출력된다.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
            //Input 입력장치. 마우스가 내려갈때 (0 = 왼쪽 마우스, 1 = 오른쪽 마우스)
        {
            direction *= -1;
            //왼쪽 마우스를 누르면 방향이 반대로 전환된다.
            renderer.flipX = !renderer.flipX;
            //왼쪽 마우스를 누르면 얼굴방향이 반대로 전환된다.
        }

        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            //양면을 바꾸는 기능인 flipX의 기능이 true이다(버튼이 눌리지 않고 그대로다)
            direction = -0.05f;
            //만약 르탄이의 x값이 2.6보다 커질때 
            //방향은 -(왼쪽) 방향으로 가며, 속도는 0.05이다.
        }

        if(transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            //앙면을 바꾸는 기능인 flipX의 기능이 false이다(버튼이 눌려 얼굴방향이 바뀐 상태이다)
            direction = 0.05f;
            //만약 르탄이의 x값이 2.6보다 작아질때 
            //방향은 +(오른쪽) 방향으로 가며, 속도는 0.05이다.
        }
        transform.position += Vector3.right * direction;
        //움직이는 포지션 = 1오른쪽으로 움직인다. * 방향*(속도)
    }
}
