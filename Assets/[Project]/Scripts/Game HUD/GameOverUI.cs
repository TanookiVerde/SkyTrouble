using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TanookiStudio;
using TMPro;


public class GameOverUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text highScore;
    [SerializeField] private GameObject recordPanel;
    [Space(10)]
    [SerializeField] private StatsData stats;

    public void ShowPanel()
    {
        this.canvasGroup.alpha = 1;
        this.canvasGroup.interactable = true;
        this.canvasGroup.blocksRaycasts = true;

        this.score.text = this.stats.starCount.ToString("000");

        int highScoreValue = PlayerPrefs.GetInt("highScore", 0);
        this.highScore.text = highScoreValue.ToString("000");

        if (this.stats.starCount > highScoreValue)
        {
            PlayerPrefs.SetInt("highScore", this.stats.starCount);
            recordPanel.SetActive(true);
        }
        else
        {
            recordPanel.SetActive(false);
        }
    }
}
