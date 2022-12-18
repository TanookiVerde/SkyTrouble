using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed;
    [Space(10)]
    [SerializeField] private UnityEvent<Vector3> onUpdateTargetPosition;

    private Vector3 targetPosition;
    private new Rigidbody2D rigidbody2D;

    private void Start()
    {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
        this.targetPosition = this.transform.position;

        StartCoroutine( IFollow() );
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            this.targetPosition = mousePosition;
            onUpdateTargetPosition?.Invoke(mousePosition);
        }
    }

    private IEnumerator IFollow()
    {
        while (true)
        {
            this.rigidbody2D.velocity = (this.targetPosition - this.transform.position) * speed;

            yield return new WaitForEndOfFrame();
        }
    }
}
