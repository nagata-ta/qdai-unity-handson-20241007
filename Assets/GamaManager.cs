using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// スコア表示するテキスト
    /// </summary>
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    /// <summary>
    /// 現在のスコア
    /// </summary>
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 指定したスコアを加算する
    /// </summary>
    /// <param name="scoreAdd"></param>
    public void AddScore(int scoreAdd)
    {
        currentScore += scoreAdd;
        scoreText.text = "Score : " + currentScore;
    }
}