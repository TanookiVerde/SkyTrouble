using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToVelocity : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;

    void Start()
    {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = -rigidbody2D.velocity.normalized;
    }
}
