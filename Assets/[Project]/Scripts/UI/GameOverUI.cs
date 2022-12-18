using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TanookiStudio;
using TMPro;


public class GameOverUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private TMP_Text score;
    [Space(10)]
    [SerializeField] private StatsData stats;

    public void ShowPanel()
    {
        this.canvasGroup.alpha = 1;
        this.canvasGroup.interactable = true;
        this.canvasGroup.blocksRaycasts = true;

        this.score.text = this.stats.starCount.ToString("000");
    }
}
