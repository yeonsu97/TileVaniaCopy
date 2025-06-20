using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper; //선언
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>(); //씬(다른 오브젝트)에서 컴포넌트(기능) 찾아 연결
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of " + 
                                scoreKeeper.CalculateScore() + "%";
    }
}
