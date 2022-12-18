using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TanookiStudio;
using TMPro;

public class StarCounterUI : MonoBehaviour
{
    [SerializeField] private StatsData stats;
    [SerializeField] private GameFlag onStarGet;
    [SerializeField] private TMP_Text value;

    private void Start()
    {
        this.stats.starCount = 0;
        UpdateVisual();

        onStarGet.onTrigger.AddListener(IncreaseStarCount);
    }

    public void IncreaseStarCount()
    {
        this.stats.starCount++;
        UpdateVisual();
    }
    private void UpdateVisual()
    {
        value.text = this.stats.starCount.ToString("000");
    }
}
