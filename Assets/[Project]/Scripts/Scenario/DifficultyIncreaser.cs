using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TanookiStudio;

public class DifficultyIncreaser : MonoBehaviour
{
    [SerializeField] private StatsData stats;
    [SerializeField] private GameFlag onStatChange;

    [SerializeField] private GlobalFloatVariable difficultyIncreaseTax;
    [SerializeField] private float minDifficultyTax;

    public void Start()
    {
        difficultyIncreaseTax.SetValue(1f);

        onStatChange.onTrigger.AddListener(UpdateValues);
    }
    public void UpdateValues()
    {
        float newValue = Mathf.Clamp(1 - stats.starCount * 0.05f, minDifficultyTax, 1);

        difficultyIncreaseTax.SetValue(newValue);
    }
}
