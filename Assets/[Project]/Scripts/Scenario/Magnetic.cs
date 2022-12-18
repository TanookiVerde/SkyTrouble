using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetic : MonoBehaviour
{
    [SerializeField] private float attractionIntensity;

    void Update()
    {
        foreach(var magnetic in FindObjectsOfType<Magnetic>())
        {
            var direction = (magnetic.transform.position - this.transform.position).normalized;
            magnetic.GetComponent<Rigidbody2D>().AddForce(-attractionIntensity * direction * Time.deltaTime);
        }
    }
}
