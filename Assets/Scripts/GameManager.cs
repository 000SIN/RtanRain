using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public GameObject endPanel;

    public Text totalScoreTxt;
    public Text timeTxt;

    int totalScore;
    // Start is called before the first frame update

    float totalTime = 30.0f;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;//�ð��� �帣�� ������
    }
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
        //������� �ݺ��ؼ� �����Ѵ�. 0�� ���� 1�� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime > 0f)
        {
            totalTime -= Time.deltaTime;

        }
        else
        {
            totalTime = 0f;
            endPanel.SetActive(true);//���� ������Ʈ�� ���ְڴ�.
            Time.timeScale = 0f;//�ð� �帣�°� ����
        }
        
        timeTxt.text = totalTime.ToString("N2");//N2 = �Ҽ��� ��°�ڸ� ������
    }

    void MakeRain()
    //������� ����� �ش�
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
        //totalSCoreTxt�� �������̶� stirng�� ������ totalScore�� �ڷ����̶� int�� ����.
        //�̷� ���� �ڷ��� �ڿ� ToString�� �ٿ� ���������� ��ȯ���� ������ָ� �ȴ�.
    }
}
