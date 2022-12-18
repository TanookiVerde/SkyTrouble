using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacialAnimation : MonoBehaviour
{
    public Transform faceRoot;
    public float maxDistanceX;
    public float maxDistanceY;

    private Vector3 center;

    private void Start()
    {
        center = faceRoot.transform.localPosition;
    }

    void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        var direction = (mousePosition - this.transform.position).normalized;
        direction.x = direction.x * maxDistanceX;
        direction.y = direction.y * maxDistanceY;

        faceRoot.transform.localPosition = center + direction;
    }
}
