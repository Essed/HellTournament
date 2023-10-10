using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private SetScore setScore;
    [SerializeField] private Text scoreText; // ссылка на текст в UI   

    private void Start()
    {
        scoreText = GameObject.FindWithTag("TextScore").GetComponent<Text>();
        setScore = GameObject.FindWithTag("TextScore").GetComponent<SetScore>();
    }

    // Метод начисления очков за убийство
    public void IncreaseScore(int _score)
    {                 
      setScore.score += _score;
        
      scoreText.text = setScore.score.ToString();        
    }
}
