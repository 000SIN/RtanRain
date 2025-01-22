using UnityEngine;

[Rain.cs]

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        float x = Random.Range(-2.4f, 2.4f);
        //원의 가로 위치를 지정하는 것이며 랜덤으로 떨어지고 범위는 -2.4 ~ 2.4 사이이다.
        float y = Random.Range(3.0f, 5.0f);
        // 원의 세로 위치를 지정하는 것이며 랜덤으로 떨어지고 범위는 3.0 ~ 5.0 사이이다.

        transform.position = new Vector3(x, y, 0);
        //위의 사항들을 화면에 나타냄. x와 y의 위치를 조절하니 z만 제외하고는 x와 y는 표기

        int type = Random.Range(1, 4);

        if (type == 1)
        {
            size = 0.8f;
            score = 1;
            renderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
        }
        else if (type == 2)
        {
            size = 1.0f;
            score = 2;
            renderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
        }
        else if (type == 3)
        {
            size = 1.2f;
            score = 3;
            renderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    //충돌이 일어나는 순간
    {
        if (collision.gameObject.CompareTag("Ground"))
        //만약 Tag가 Ground인 게임 오브젝트와 충돌하였을 때
        {
            Destroy(this.gameObject);
            //this = Rain 스크립트 자기 자신. 스스로를 파괴하여라.
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}