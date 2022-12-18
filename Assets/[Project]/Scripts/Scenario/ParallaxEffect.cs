using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private float speed;

    private new SpriteRenderer renderer;

    private void Start()
    {
        this.renderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        var currentSize = this.renderer.size;
        currentSize.x += speed * Time.deltaTime;

        this.renderer.size = currentSize;
    }
}
