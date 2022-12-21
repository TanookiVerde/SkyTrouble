using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomColorSetter : MonoBehaviour
{
    [SerializeField] private Color baseColor;
    [SerializeField] private Vector3 colorVariance;

    private SpriteRenderer spriteRenderer;
    private Image imageRenderer;

    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.imageRenderer = GetComponent<Image>();

        if (this.imageRenderer == null)
        {
            Color currentColor = this.spriteRenderer.color;
            currentColor.r = baseColor.r + Random.Range(-colorVariance.x, colorVariance.x);
            currentColor.g = baseColor.g + Random.Range(-colorVariance.y, colorVariance.y);
            currentColor.b = baseColor.b + Random.Range(-colorVariance.z, colorVariance.z);
            this.spriteRenderer.color = currentColor;
        }
        else if (this.spriteRenderer == null)
        {
            Color currentColor = this.imageRenderer.color;
            currentColor.r = baseColor.r + Random.Range(-colorVariance.x, colorVariance.x);
            currentColor.g = baseColor.g + Random.Range(-colorVariance.y, colorVariance.y);
            currentColor.b = baseColor.b + Random.Range(-colorVariance.z, colorVariance.z);
            this.imageRenderer.color = currentColor;
        }
        else
        {
            throw new System.Exception("No Renderer Available (Sprite Renderer or Image)");
        }
    }
}
