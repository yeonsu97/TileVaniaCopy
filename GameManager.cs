using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz; //선언
    EndScreen endScreen;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>(); //씬(다른 오브젝트)에서 컴포넌트(기능) 찾아 연결
        endScreen = FindObjectOfType<EndScreen>();
    }

    void Start()
    { 
        quiz.gameObject.SetActive(true);
        // 퀴즈 오브젝트 활성화
        // 퀴즈 스크립트를 가지고 있는 오브젝트들을 활성화화
        endScreen.gameObject.SetActive(false);
        // 엔드 스크린 오브젝트 비활성화
    }

    void Update()
    {
        if (quiz.isComplete == true)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void OnReplayLevel() // 레벨 재시작
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // SceneManager.LoadScene(); 새로운 화면으로 이동
        // SceneManager.GetActiveScene(); 지금 보고 있는 화면
        // .buildIndex 화면의 번호
    }
}
