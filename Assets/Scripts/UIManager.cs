using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private int scoreCoinShine;
    private int scoreCoinSpin;
    private int scoreHeart;
    private TextMeshProUGUI scoreTextCoinShineUI;
    private TextMeshProUGUI scoreTextCoinSpinUI;
    private TextMeshProUGUI scoreTextHeartUI;

    private void Awake()
    {
        instance = this;
        scoreTextCoinShineUI = GameObject.Find("ScoreTextCoinShineUI").GetComponent<TextMeshProUGUI>();
        scoreTextCoinSpinUI = GameObject.Find("ScoreTextCoinSpinUI").GetComponent<TextMeshProUGUI>();
        scoreTextHeartUI = GameObject.Find("ScoreTextHeartUI").GetComponent<TextMeshProUGUI>();
    }

    public void AddScoreUICoinshine()
    {
        scoreCoinShine++;
        scoreTextCoinShineUI.text = scoreCoinShine.ToString();
    }

    public void AddScoreUICoinspin()
    {
        scoreCoinSpin++;
        scoreTextCoinSpinUI.text = scoreCoinSpin.ToString();
    }

    public void AddScoreUIHeart()
    {
        scoreHeart++;
        scoreTextHeartUI.text = scoreHeart.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Prototype");
    }

}
