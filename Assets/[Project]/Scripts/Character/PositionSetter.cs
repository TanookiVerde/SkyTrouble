using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSetter : MonoBehaviour
{
    public void SetPosition(Vector3 position)
    {
        this.transform.position = position;
    }
}
