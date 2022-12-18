using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private UnityEvent onAnyCollision;

    [SerializeField] private List<CollisionReaction> reactions;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onAnyCollision?.Invoke();

        foreach(var reaction in reactions)
        {
            if (collision.collider.CompareTag(reaction.tag))
            {
                reaction.onCollision?.Invoke();
                break;
            }
        }
    }
}
[System.Serializable]
public class CollisionReaction
{
    public string tag;
    public UnityEvent onCollision;
}
