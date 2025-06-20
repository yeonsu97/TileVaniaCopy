using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0; // 정답 개수
    int questionsSeen = 0; // 총 푼 문제 개수

    public int GetCorrectAnswers() // 정답 개수 반환
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers() // 정답 개수 증가
    {
        correctAnswers++;
    }

    public int GetQuestionSeen() // 총 푼 문제 개수 반환
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen() // 총 푼 문제 개수 증가
    {
        questionsSeen++;
    }

    public int CalculateScore() // 점수 계산
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
        // 정답 개수를 총 푼 문제 개수로 나누고 100을 곱해서 점수 계산 (정답률)
    }
}
