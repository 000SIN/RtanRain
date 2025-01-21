using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direction = 0.05f;
    // direction �� 0.05f �̴�.

    SpriteRenderer renderer;
    //SpriteRenderer�� renderer��� �����Ѵ�.

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //1�ʿ� 60���������� �����Ѵ�.
        renderer = GetComponent<SpriteRenderer>(); //renderer�� SpriteRender�� ����� ����Ѵ�.
        // Debug.Log("�ȳ�"); //�����ϸ� �ȳ��̶�� ���� �α׿� ��µȴ�.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
            //Input �Է���ġ. ���콺�� �������� (0 = ���� ���콺, 1 = ������ ���콺)
        {
            direction *= -1;
            //���� ���콺�� ������ ������ �ݴ�� ��ȯ�ȴ�.
            renderer.flipX = !renderer.flipX;
            //���� ���콺�� ������ �󱼹����� �ݴ�� ��ȯ�ȴ�.
        }

        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            //����� �ٲٴ� ����� flipX�� ����� true�̴�(��ư�� ������ �ʰ� �״�δ�)
            direction = -0.05f;
            //���� ��ź���� x���� 2.6���� Ŀ���� 
            //������ -(����) �������� ����, �ӵ��� 0.05�̴�.
        }

        if(transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            //�Ӹ��� �ٲٴ� ����� flipX�� ����� false�̴�(��ư�� ���� �󱼹����� �ٲ� �����̴�)
            direction = 0.05f;
            //���� ��ź���� x���� 2.6���� �۾����� 
            //������ +(������) �������� ����, �ӵ��� 0.05�̴�.
        }
        transform.position += Vector3.right * direction;
        //�����̴� ������ = 1���������� �����δ�. * ����*(�ӵ�)
    }
}
