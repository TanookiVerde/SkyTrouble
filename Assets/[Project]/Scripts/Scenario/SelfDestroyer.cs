using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SelfDestroyer : MonoBehaviour
{
    [SerializeField] private bool skipAnimation;

    public void DestroySelf()
    {
        StartCoroutine(IDestroyAnimation());
    }
    private IEnumerator IDestroyAnimation()
    {
        foreach(var collider in transform.GetComponents<Collider2D>())
            collider.enabled = false;

        if (!skipAnimation)
        {
            transform.DOScale(1.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);

            transform.DOScale(0f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        GameObject.Destroy(this.gameObject);
    }
}
