using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f; // 문제를 푸는 시간
    [SerializeField] float timeToShowCorrectAnswer = 10f; // 정답을 보여주는 시간

    public bool loadNextQuestion; // 다음 문제로 넘어가야 할 때
    public float fillFraction; // 진행 바의 채우기 정도
    public bool isAnsweringQuestion; // 문제를 푸는 중인지 여부
    
    float timerValue; // 타이머 값

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue = timerValue - Time.deltaTime;
        //Time.deltaTime은 이전 프레임과의 시간 차이

        if(isAnsweringQuestion) // 문제 풀이 중일 때
        {
            if(timerValue > 0) // 타이머가 0보다 클 때
            {
                fillFraction = timerValue / timeToCompleteQuestion; 
                // 진행 바의 채우기 정도 계산, 타이머 값 나누기 문제 풀이 시간
            }
            else // 타이머가 0보다 작거나 같을 때
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else // 정답을 보여주는 중일 때
        {
            if(timerValue > 0) // 타이머가 0보다 클 때
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
                // 진행 바의 채우기 정도 계산, 타이머 값 나누기 정답 보여주는 시간
            }
            else // 타이머가 0보다 작거나 같을 때
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true; // 다음 문제로 넘어가야 함
            }
        }
    }
}
