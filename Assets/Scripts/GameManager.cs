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
        Time.timeScale = 1f;//시간이 흐르기 시작함
    }
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
        //빗방울을 반복해서 생성한다. 0초 부터 1초 마다
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
            endPanel.SetActive(true);//게임 오브젝트를 켜주겠다.
            Time.timeScale = 0f;//시간 흐르는게 멈춤
        }
        
        timeTxt.text = totalTime.ToString("N2");//N2 = 소수점 둘째자리 까지만
    }

    void MakeRain()
    //빗방울을 만들어 준다
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreTxt.text = totalScore.ToString();
        //totalSCoreTxt는 문자형이라 stirng을 쓰지만 totalScore는 자료형이라 int를 쓴다.
        //이럴 때는 자료형 뒤에 ToString을 붙여 문자형으로 변환시켜 사용해주면 된다.
    }
}
