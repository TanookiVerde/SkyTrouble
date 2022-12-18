using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class RandomColorSetter : MonoBehaviour
{
    [SerializeField] private Color baseColor;
    [SerializeField] private Vector3 colorVariance;

    private SpriteRenderer spriteRenderer;


    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();

        Color currentColor = this.spriteRenderer.color;
        currentColor.r = baseColor.r + Random.Range(-colorVariance.x, colorVariance.x);
        currentColor.g = baseColor.g + Random.Range(-colorVariance.y, colorVariance.y);
        currentColor.b = baseColor.b + Random.Range(-colorVariance.z, colorVariance.z);
        this.spriteRenderer.color = currentColor;
    }
}
